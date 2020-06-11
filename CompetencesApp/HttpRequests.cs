using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace CompetencesApp
{
    class HttpRequests
    {
        public static HttpClient client = new HttpClient();
        public static async Task<List<Promotion>> GetPromotions()
        {
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/promotions");
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
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/users");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<User>>();
                return list;
            }
            List<User> other_list = new List<User>();
            return other_list;
        }

        public static async Task<List<Promotion>> GetUsersPromotionById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/users/" + id + "/promotions");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Promotion>>();
                return list;
            }
            List<Promotion> other_list = new List<Promotion>();
            return other_list;
        }


        public static async Task<List<UserCompetence>> GetUsersCompetencesById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/users/" + id + "/competences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<UserCompetence>>();

                return list;
            }
            List<UserCompetence> other_list = new List<UserCompetence>();
            return other_list;
        }

        public static async Task<Competence> GetCompetenceById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/competences/" + id);
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
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/promotions/" + id + "/competenceblocks");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<CompetenceBlock>>();
                return list;
            }
            List<CompetenceBlock> other_list = new List<CompetenceBlock>();
            return other_list;
        }

        public static async Task<List<Competence>> GetCompetenceBlocksCompetencesById(string id)
        {
            var httpResponseMessage = await client.GetAsync("http://91.171.37.70:16384/competenceblocks/" + id + "/competences");
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var list = await content.ReadAsAsync<List<Competence>>();
                return list;
            }
            List<Competence> other_list = new List<Competence>();
            return other_list;
        }


        //public static async Task<User> UserLogin(string username, string password)
        //{
        //    List<string> list = new List<string>();
        //    list.Add(username);
        //    list.Add(password);
        //    HttpResponseMessage response = await client.PostAsJsonAsync(
        //        "http://91.171.37.70:16384/login", list);
        //    response.EnsureSuccessStatusCode();
        //    Console.WriteLine(response.Content);
        //    var user = await response.Content.ReadAsAsync<User>();
        //    var userpromo = await HttpRequests.GetUsersPromotionById(user._id);
        //    var usercompetence = await HttpRequests.GetUsersCompetencesById(user._id);
        //    user.promos = userpromo;
        //    user.comps = usercompetence;

        //    return user;
        //}

        public static async Task<User> UserLogin(string username, string password)
        {
            List<string> list = new List<string>();
            list.Add(username);
            list.Add(password);

            HttpResponseMessage response = await client.PostAsJsonAsync("http://91.171.37.70:16384/login", list);
            response.EnsureSuccessStatusCode();

            //Console.WriteLine(response.Content);

            var user = await response.Content.ReadAsAsync<User>();

            if (!user.isAdmin)
            {
                var userpromoslist = await HttpRequests.GetUsersPromotionById(user._id);
                user.promos = userpromoslist;
            }
            else
            {
                var userpromoslist = await HttpRequests.GetPromotions();
                user.promos = userpromoslist;
            }

            var usercompetenceslist = await HttpRequests.GetUsersCompetencesById(user._id);

            

            user.comps = usercompetenceslist;
            return user;
        }
    }
}
