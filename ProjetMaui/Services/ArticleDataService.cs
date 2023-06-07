using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMaui.Services
{
    public class ArticleDataService
    {
        public async Task<IEnumerable<Article>> GetItems()
        {
            await Task.Delay(1000); // Artifical delay to give the impression of work
            return ListOfArticles;
        }
        public List<Article> ListOfArticles = new List<Article>() {
                new Article()
            {
                Id = 1,
                Title = "Introduction à la programmation en C#",
                Description = "Un guide complet sur le langage de programmation C#",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            },

            new Article()
            {
                Id = 2,
                Title = "Concepts de programmation orientée objet",
                Description = "Exploration des concepts fondamentaux de la programmation orientée objet",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté_avec_modification },
                Justificatory = "Révisions mineures requises"
            },

            new Article()
            {
                Id = 3,
                Title = "Manipulation des données avec LINQ",
                Description = "Utilisation de LINQ pour interroger et manipuler des données en C#",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            },

                new Article()
            {
                Id = 4,
                Title = "Gestion des exceptions en C#",
                Description = "Comprendre comment gérer les exceptions en C#",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            },

                new Article()
            {
                Id = 5,
                Title = "Développement Web avec ASP.NET Core",
                Description = "Construction d'applications Web en utilisant le framework ASP.NET Core",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté_avec_modification },
                Justificatory = "Révisions mineures requises"
            },

            new Article()
            {
                Id = 6,
                Title = "Conception de bases de données et normalisation",
                Description = "Conception de bases de données efficaces et normalisées",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            },

            new Article()
            {
                Id = 7,
                Title = "Travailler avec Entity Framework",
                Description = "Utilisation d'Entity Framework pour l'accès à la base de données en C#",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            },

                new Article()
            {
                Id = 8,
                Title = "Pratiques de codage sécurisé",
                Description = "Meilleures pratiques pour écrire un code sécurisé en C#",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté_avec_modification },
                Justificatory = "Révisions mineures requises"
            },

            new Article()
            {
                Id = 9,
                Title = "Introduction à Xamarin.Forms",
                Description = "Construction d'applications mobiles multiplateformes avec Xamarin.Forms",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            },

            new Article()
            {
                Id = 10,
                Title = "Multithreading en C#",
                Description = "Exploration du multithreading et de la programmation parallèle en C#",
                IsSubmitted = true,
                Getstatus = new Article.Article_status[] { Article.Article_status.accepté },
                Justificatory = "N/A"
            }
        };
    }
}
