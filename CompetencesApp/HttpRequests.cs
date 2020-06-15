using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CompetencesApp
{
    class HttpRequests
    {
        public static HttpClient client = new HttpClient();
        private static string host;
        public static async Task<List<Promotion>> GetPromotions()
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/promotions");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Promotion>>();
                return list;
            }
            List<Promotion> other_list = new List<Promotion>();
            return other_list;
        }

        public static async Task<List<User>> GetUsers()
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/users");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<User>>();
                if (list == null) return new List<User>();
                List<User> returnList = new List<User>();

                list.ForEach(async (user) =>
                {
                    if (user.isTeacher)
                    {
                        Teacher teacher = new Teacher(user);
                        teacher.teacherCompetence = await GetAllTeacherCompetenceById(teacher._id);
                        returnList.Add(teacher);
                    }
                    else
                    {
                        returnList.Add(user);
                    }
                });

                return returnList;
            }
            List<User> other_list = new List<User>();
            return other_list;
        }
        public static async Task<List<Competence>> GetCompetences()
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/competences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Competence>>();
                if (list == null) return new List<Competence>();

                return list;
            }
            List<Competence> other_list = new List<Competence>();
            return other_list;
        }

        public static async Task<List<CompetenceBlock>> GetCompetenceBlocks()
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/competenceblocks");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<CompetenceBlock>>();
                if (list == null) return new List<CompetenceBlock>();
                return list;
            }
            List<CompetenceBlock> other_list = new List<CompetenceBlock>();
            return other_list;
        }
        public static async Task<List<Promotion>> GetUsersPromotionById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/users/" + id + "/promotions");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Promotion>>();
                return list;
            }
            List<Promotion> other_list = new List<Promotion>();
            return other_list;
        }

        public static async Task<List<User>> GetAllUserByPromotionId(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/promotions/" + id + "/users");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<User>>();
                if (list == null) list = new List<User>();
                return list;
            }
            List<User> other_list = new List<User>();
            return other_list;
        }

        public static async Task<Promotion> PatchPromotionUsers(string promotionId, List<User> users)
        {

            string payload;


            List<string> usersId = new List<string>();

            users.ForEach((user) => usersId.Add(user._id));
            payload = JsonConvert.SerializeObject(new
            {
                users = usersId,
            });


            var request = new HttpRequestMessage(HttpMethod.Put, "http://" + host + "/promotions/" + promotionId + "/users");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var promotion = await response.Content.ReadAsAsync<Promotion>();
            return promotion;
        }
        public static async Task<bool> PatchPromotionCompetenceBlocks(string promotionId, List<CompetenceBlock> competenceBlocks)
        {

            string payload;


            List<string> blockId = new List<string>();

            competenceBlocks.ForEach((block) => blockId.Add(block._id));
            payload = JsonConvert.SerializeObject(new
            {
                competenceblocks = blockId,
            });


            var request = new HttpRequestMessage(HttpMethod.Put, "http://" + host + "/promotions/" + promotionId + "/competenceblocks");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            return true;
        }
        public static async Task<CompetenceBlock> PatchCompetenceBlockCompetence(string blockId, List<Competence> competences)
        {

            string payload;


            List<string> competenceId = new List<string>();

            competences.ForEach((competence) => competenceId.Add(competence._id));

            payload = JsonConvert.SerializeObject(new
            {
                competence = competenceId,
            });


            var request = new HttpRequestMessage(HttpMethod.Put, "http://" + host + "/competenceblocks/" + blockId + "/competences");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            CompetenceBlock block = new CompetenceBlock();
            try
            {
                block = await response.Content.ReadAsAsync<CompetenceBlock>();

            }
            catch
            {
                block.competence = await GetCompetenceBlocksCompetencesById(block._id);
            }
            return block;
        }

        public static async Task<bool> PatchTeacherCompetences(string teacherId, List<Competence> competences)
        {

            string payload;

            List<string> competenceId = new List<string>();

            competences.ForEach((competence) => competenceId.Add(competence._id));

            payload = JsonConvert.SerializeObject(new
            {
                competences = competenceId,
            });


            var request = new HttpRequestMessage(HttpMethod.Put, "http://" + host + "/users/" + teacherId + "/teachercompetences");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            //List<Competence> teacherComps = await response.Content.ReadAsAsync<List<Competence>>();
            return true;
            //return teacherComps;
        }

        public static async Task<List<UserCompetence>> GetUsersCompetencesById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/users/" + id + "/competences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<UserCompetence>>();

                return list;
            }
            List<UserCompetence> other_list = new List<UserCompetence>();
            return other_list;
        }
        public static async Task<List<Competence>> GetAllTeacherCompetenceById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/users/" + id + "/teachercompetences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Competence>>();
                if (list == null) return new List<Competence>();

                return list;
            }
            List<Competence> other_list = new List<Competence>();
            return other_list;
        }

        public static async Task<Competence> GetCompetenceById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/competences/" + id);
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var comp = await content.ReadAsAsync<Competence>();

                return comp;
            }
            Competence othercomp = new Competence();
            return othercomp;
        }
        public static async Task<List<CompetenceBlock>> GetPromotionsCompetenceBlocksById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/promotions/" + id + "/competenceblocks");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                List<CompetenceBlock> list = new List<CompetenceBlock>();
                try
                {
                    list = await content.ReadAsAsync<List<CompetenceBlock>>();
                }
                catch
                {

                }

                return list;
            }
            List<CompetenceBlock> other_list = new List<CompetenceBlock>();
            return other_list;
        }

        public static async Task<List<Competence>> GetCompetenceBlocksCompetencesById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/competenceblocks/" + id + "/competences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Competence>>();
                return list;
            }
            List<Competence> other_list = new List<Competence>();
            return other_list;
        }

        public static async Task<List<UserCompetenceTeacher>> GetUserCompetenceTeacherById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/competences/" + id + "/usercompetences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<UserCompetenceTeacher>>();
                return list;
            }
            List<UserCompetenceTeacher> other_list = new List<UserCompetenceTeacher>();
            return other_list;
        }


        //public static async Task<User> UserLogin(string username, string password)
        //{
        //    List<string> list = new List<string>();
        //    list.Add(username);
        //    list.Add(password);
        //    HttpResponseMessage response = await client.PostAsJsonAsync(
        //        "http://" + host + "/login", list);
        //    response.EnsureSuccessStatusCode();
        //    Console.WriteLine(response.Content);
        //    var user = await response.Content.ReadAsAsync<User>();
        //    var userpromo = await HttpRequests.GetUsersPromotionById(user._id);
        //    var usercompetence = await HttpRequests.GetUsersCompetencesById(user._id);
        //    user.promos = userpromo;
        //    user.comps = usercompetence;

        //    return user;
        //}

        //public static async Task<User> UserLogin(string username, string password)
        //{
        //    List<string> list = new List<string>();
        //    list.Add(username);
        //    list.Add(password);

        //    HttpResponseMessage response = await client.PostAsJsonAsync("http://" + host + "/login", list);
        //    response.EnsureSuccessStatusCode();

        //    //Console.WriteLine(response.Content);

        //    var user = await response.Content.ReadAsAsync<User>();

        //    if (!user.isAdmin)
        //    {
        //        var userpromoslist = await HttpRequests.GetUsersPromotionById(user._id);
        //        user.promos = userpromoslist;
        //    }
        //    else
        //    {
        //        var userpromoslist = await HttpRequests.GetPromotions();
        //        user.promos = userpromoslist;
        //    }

        //    var usercompetenceslist = await HttpRequests.GetUsersCompetencesById(user._id);



        //    user.comps = usercompetenceslist;
        //    return user;
        //}

        public static async Task<dynamic> UserLogin(string username, string password)
        {

            string payload = JsonConvert.SerializeObject(new
            {
                username = username,
                password = password
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/login");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode(); // Ici il faut que tu check try catch, si ça fail c'est que le user s'est trompé de password ou serv off, faudra check comment on peut afficher ça

            // 404 


            var userJObject = await response.Content.ReadAsAsync<JObject>();
            //Console.WriteLine(((bool)user.GetValue("isAdmin"))?"VRAI":"FAUX") ;

            var isAdmin = false;
            var isTeacher = false;
            var competence = new List<string>();
            try
            {
                isAdmin = (bool)userJObject.GetValue("isAdmin");
                isTeacher = (bool)userJObject.GetValue("isTeacher");
            }
            catch (Exception e)
            {
            }


            if (isAdmin)
            {
                //var userpromoslist = await HttpRequests.GetPromotions();
                //user.promos = userpromoslist;

                var user = userJObject.ToObject<Admin>();
                user.competences = await GetCompetences();
                user.competenceblocks = await GetCompetenceBlocks();
                user.users = await GetUsers();
                user.promos = await GetPromotions();

                return user;
            }
            else if (isTeacher)
            {
                var user = userJObject.ToObject<Teacher>();
                user.teacherCompetence = await GetAllTeacherCompetenceById(user._id);


                return user;
            }
            else
            {
                var user = userJObject.ToObject<User>();

                var userpromoslist = await HttpRequests.GetUsersPromotionById(user._id);
                user.promos = userpromoslist;
                var usercompetenceslist = await HttpRequests.GetUsersCompetencesById(user._id);
                user.comps = usercompetenceslist;

                return user;
            }

        }

        public static async Task<UserCompetence> PostCompetenceId(string competenceid, string userid)
        {

            string payload = JsonConvert.SerializeObject(new
            {
                competenceId = competenceid
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/users/" + userid + "/competences");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var usercomp = await response.Content.ReadAsAsync<UserCompetence>();
            return usercomp;
        }

        public static async Task<List<Document>> GetDocumentsByUserCompetenceId(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/usercompetences/" + id + "/documents");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Document>>();
                return list;
            }
            List<Document> other_list = new List<Document>();
            return other_list;
        }

        //PatchUserComp
        public static async Task<UserCompetence> PatchUserCompetence(UserCompetence usercompetence, bool isTeacher)
        {

            string payload;
            if (isTeacher)
            {
                payload = JsonConvert.SerializeObject(new
                {
                    isValidated = usercompetence.isValidated,
                    teacherPercent = usercompetence.teacherPercent
                });
            }
            else
            {
                payload = JsonConvert.SerializeObject(new
                {
                    userPercent = usercompetence.userPercent
                });
            }
            var request = new HttpRequestMessage(HttpMethod.Put, "http://" + host + "/usercompetences/" + usercompetence._id);
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var usercomp = await response.Content.ReadAsAsync<UserCompetence>();
            return usercomp;
        }

        public static async Task<Document> PostDocument(string usercompetenceid, string link)
        {

            string payload = JsonConvert.SerializeObject(new
            {
                link = link
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/usercompetences/" + usercompetenceid + "/documents");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var doc = await response.Content.ReadAsAsync<Document>();
            return doc;
        }

        public static async void DeleteDocument(string usercompetenceid, string documentid)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "http://" + host + "/usercompetences/" + usercompetenceid + "/documents/" + documentid);


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            //var doc = await response.Content.ReadAsAsync<Document>();
            //return doc;
        }

        public static async Task<List<Resource>> GetResourceByCompetenceId(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://" + host + "/competences/" + id + "/ressources");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var reslist = await content.ReadAsAsync<List<Resource>>();
                return reslist;
            }
            List<Resource> other_reslist = new List<Resource>();
            return other_reslist;
        }

        public static async Task<Resource> PostRessourceByCompetenceId(string compid, string title, string content)
        {

            string payload = JsonConvert.SerializeObject(new
            {
                title = title,
                content = content,
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/competences/" + compid + "/ressources");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var resource = await response.Content.ReadAsAsync<Resource>();
            return resource;
        }

        public static async Task<bool> DeleteRessource(string competenceid, string ressourceid)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "http://" + host + "/competences/" + competenceid + "/ressources/" + ressourceid);


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static async Task<bool> DeleteUser(string userId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "http://" + host + "/users/" + userId);


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static async Task<bool> DeletePromotion(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "http://" + host + "/promotions/" + id);


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static async Task<bool> DeleteCompetenceBlock(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "http://" + host + "/competenceblocks/" + id);


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                return false;
            }

            return true;
        }
        public static async Task<bool> DeleteCompetence(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "http://" + host + "/competences/" + id);


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static async Task<User> PostCreateUser(string username, string firstname, string name, string password, bool isAdmin, bool isTeacher)
        {
            string payload = JsonConvert.SerializeObject(new
            {
                username = username,
                firstName = firstname,
                surname = name,
                clearPassword = password,
                isAdmin = isAdmin,
                isTeacher = isTeacher
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/users");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var user = await response.Content.ReadAsAsync<User>();
            return user;
        }

        public static async Task<Promotion> PostCreatePromotion(string name)
        {
            string payload = JsonConvert.SerializeObject(new
            {
                name = name
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/promotions");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var promotion = await response.Content.ReadAsAsync<Promotion>();
            return promotion;
        }

        public static async Task<CompetenceBlock> PostCreateCompetenceBlock(string name, string description)
        {
            string payload = JsonConvert.SerializeObject(new
            {
                name = name,
                description = description
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/competenceblocks");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var competenceblock = await response.Content.ReadAsAsync<CompetenceBlock>();
            return competenceblock;
        }

        public static async Task<Competence> PostCreateCompetence(string name, string description)
        {
            string payload = JsonConvert.SerializeObject(new
            {
                name = name,
                description = description
            });
            var request = new HttpRequestMessage(HttpMethod.Post, "http://" + host + "/competences");
            var stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = stringContent;


            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();


            var competence = await response.Content.ReadAsAsync<Competence>();
            return competence;
        }
    }
}
