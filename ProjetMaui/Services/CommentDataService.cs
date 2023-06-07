using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMaui.Services
{
    public class CommentDataService
    {
        public async Task<IEnumerable<Comment>> GetItems()
        {
            await Task.Delay(1000); // Artifical delay to give the impression of work
            return ListOfComment;
        }
        List<Comment> ListOfComment = new List<Comment>
        {
            new Comment
            {
                Id = 1,
                Libelle = "Très intéressante présentation sur le Machine Learning ! Merci aux organisateurs.",
                User = new User
                {
                    Id = "1",
                    Name = "John Doe",
                    Email = "john.doe@example.com"
                },
                Conference = new Conference()
            {
                Id = 1,
                Name = "Conférence sur l'intelligence artificielle",
                Sigle = "CONF-IA",
                Theme = "Avancées récentes en intelligence artificielle",
                SubmissionStartDate = new DateTime(2023, 1, 1),
                SubmissionEndDate = new DateTime(2023, 2, 1),
                ResultsDate = new DateTime(2023, 2, 15),
                InscriptionStartDate = new DateTime(2023, 2, 16),
                InscriptionEndDate = new DateTime(2023, 3, 15),
                ConferenceStartDate = new DateTime(2023, 3, 16),
                ConferenceEndDate = new DateTime(2023, 3, 18)
            },
            },
            new Comment
            {
                Id = 2,
                Libelle = "La conférence était très bien organisée. Les intervenants étaient passionnants !",
                User = new User
                {
                    Id = "2",
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com"
                },
                Conference =   new Conference()
            {
                Id = 2,
                Name = "Conférence sur la biologie moléculaire",
                Sigle = "CONF-BM",
                Theme = "Découvertes récentes en biologie moléculaire",
                SubmissionStartDate = new DateTime(2023, 2, 1),
                SubmissionEndDate = new DateTime(2023, 3, 1),
                ResultsDate = new DateTime(2023, 3, 15),
                InscriptionStartDate = new DateTime(2023, 3, 16),
                InscriptionEndDate = new DateTime(2023, 4, 15),
                ConferenceStartDate = new DateTime(2023, 4, 16),
                ConferenceEndDate = new DateTime(2023, 4, 18)
            },
            },
            new Comment
            {
                Id = 3,
                Libelle = "Je suis impressionné par la qualité des présentations. Bravo à toute l'équipe !",
                User = new User
                {
                    Id = "3",
                    Name = "Alice Johnson",
                    Email = "alice.johnson@example.com"
                },
                Conference =   new Conference()
            {
                Id = 2,
                Name = "Conférence sur la biologie moléculaire",
                Sigle = "CONF-BM",
                Theme = "Découvertes récentes en biologie moléculaire",
                SubmissionStartDate = new DateTime(2023, 2, 1),
                SubmissionEndDate = new DateTime(2023, 3, 1),
                ResultsDate = new DateTime(2023, 3, 15),
                InscriptionStartDate = new DateTime(2023, 3, 16),
                InscriptionEndDate = new DateTime(2023, 4, 15),
                ConferenceStartDate = new DateTime(2023, 4, 16),
                ConferenceEndDate = new DateTime(2023, 4, 18)
            }, // Conférence 3
            },
            new Comment
            {
                Id = 4,
                Libelle = "Les sujets abordés étaient pertinents et d'actualité. J'ai beaucoup appris lors de cette conférence.",
                User = new User
                {
                    Id = "4",
                    Name = "Robert Brown",
                    Email = "robert.brown@example.com"
                },
                Conference =  new Conference()
            {
                Id = 3,
                Name = "Conférence sur la physique des particules",
                Sigle = "CONF-PP",
                Theme = "Nouvelles découvertes en physique des particules",
                SubmissionStartDate = new DateTime(2023, 3, 1),
                SubmissionEndDate = new DateTime(2023, 4, 1),
                ResultsDate = new DateTime(2023, 4, 15),
                InscriptionStartDate = new DateTime(2023, 4, 16),
                InscriptionEndDate = new DateTime(2023, 5, 15),
                ConferenceStartDate = new DateTime(2023, 5, 16),
                ConferenceEndDate = new DateTime(2023, 5, 18)
            },
            },
            new Comment
            {
                Id = 5,
                Libelle = "Félicitations aux organisateurs pour cette conférence de grande qualité !",
                User = new User
                {
                    Id = "5",
                    Name = "Emma Wilson",
                    Email = "emma.wilson@example.com"
                },
                Conference =  new Conference()
            {
                Id = 5,
                Name = "Conférence sur l'astronomie",
                Sigle = "CONF-ASTRO",
                Theme = "Découvertes récentes en astronomie",
                SubmissionStartDate = new DateTime(2023, 5, 1),
                SubmissionEndDate = new DateTime(2023, 6, 1),
                ResultsDate = new DateTime(2023, 6, 15),
                InscriptionStartDate = new DateTime(2023, 6, 16),
                InscriptionEndDate = new DateTime(2023, 7, 15),
                ConferenceStartDate = new DateTime(2023, 7, 16),
                ConferenceEndDate = new DateTime(2023, 7, 18)
            },
            },
            new Comment
            {
                Id = 6,
                Libelle = "Les conférenciers étaient très compétents et ont su transmettre leur expertise de manière claire.",
                User = new User
                {
                    Id = "6",
                    Name = "David Thompson",
                    Email = "david.thompson@example.com"
                },
                Conference =  new Conference()
            {
                Id = 5,
                Name = "Conférence sur l'astronomie",
                Sigle = "CONF-ASTRO",
                Theme = "Découvertes récentes en astronomie",
                SubmissionStartDate = new DateTime(2023, 5, 1),
                SubmissionEndDate = new DateTime(2023, 6, 1),
                ResultsDate = new DateTime(2023, 6, 15),
                InscriptionStartDate = new DateTime(2023, 6, 16),
                InscriptionEndDate = new DateTime(2023, 7, 15),
                ConferenceStartDate = new DateTime(2023, 7, 16),
                ConferenceEndDate = new DateTime(2023, 7, 18)
            },
            },
            new Comment
            {
                Id = 7,
                Libelle = "J'ai été agréablement surpris par la diversité des sujets traités lors de cette conférence.",
                User = new User
                {
                    Id = "7",
                    Name = "Sophie Anderson",
                    Email = "sophie.anderson@example.com"
                },
                Conference =  new Conference()
            {
                Id = 8,
                Name = "Conférence sur la chimie organique",
                Sigle = "CONF-CHIMIE",
                Theme = "Nouvelles découvertes en chimie organique",
                SubmissionStartDate = new DateTime(2023, 8, 1),
                SubmissionEndDate = new DateTime(2023, 9, 1),
                ResultsDate = new DateTime(2023, 9, 15),
                InscriptionStartDate = new DateTime(2023, 9, 16),
                InscriptionEndDate = new DateTime(2023, 10, 15),
                ConferenceStartDate = new DateTime(2023, 10, 16),
                ConferenceEndDate = new DateTime(2023, 10, 18)
            },
                
            },
            new Comment
            {
                Id = 8,
                Libelle = "Les ateliers pratiques étaient très utiles pour mettre en pratique les concepts présentés en séance plénière.",
                User = new User
                {
                    Id = "8",
                    Name = "James Wilson",
                    Email = "james.wilson@example.com"
                },
                Conference =   new Conference()
            {
                Id = 8,
                Name = "Conférence sur la chimie organique",
                Sigle = "CONF-CHIMIE",
                Theme = "Nouvelles découvertes en chimie organique",
                SubmissionStartDate = new DateTime(2023, 8, 1),
                SubmissionEndDate = new DateTime(2023, 9, 1),
                ResultsDate = new DateTime(2023, 9, 15),
                InscriptionStartDate = new DateTime(2023, 9, 16),
                InscriptionEndDate = new DateTime(2023, 10, 15),
                ConferenceStartDate = new DateTime(2023, 10, 16),
                ConferenceEndDate = new DateTime(2023, 10, 18)
            },
            },
            new Comment
            {
                Id = 9,
                Libelle = "Merci pour cette conférence inspirante ! J'ai hâte de mettre en pratique ce que j'ai appris.",
                User = new User
                {
                    Id = "9",
                    Name = "Olivia Brown",
                    Email = "olivia.brown@example.com"
                },
                Conference =  new Conference()
            {
                Id = 10,
                Name = "Conférence sur la bioinformatique",
                Sigle = "CONF-BIOINFO",
                Theme = "Découvertes récentes en bioinformatique",
                SubmissionStartDate = new DateTime(2023, 10, 1),
                SubmissionEndDate = new DateTime(2023, 11, 1),
                ResultsDate = new DateTime(2023, 11, 15),
                InscriptionStartDate = new DateTime(2023, 11, 16),
                InscriptionEndDate = new DateTime(2023, 12, 15),
                ConferenceStartDate = new DateTime(2023, 12, 16),
                ConferenceEndDate = new DateTime(2023, 12, 18)
            },
            },
            new Comment
            {
                Id = 10,
                Libelle = "Les échanges entre participants étaient enrichissants. Je suis reparti avec de nouvelles idées.",
                User = new User
                {
                    Id = "10",
                    Name = "William Davis",
                    Email = "william.davis@example.com"
                },
                Conference = new Conference()
            {
                Id = 10,
                Name = "Conférence sur la bioinformatique",
                Sigle = "CONF-BIOINFO",
                Theme = "Découvertes récentes en bioinformatique",
                SubmissionStartDate = new DateTime(2023, 10, 1),
                SubmissionEndDate = new DateTime(2023, 11, 1),
                ResultsDate = new DateTime(2023, 11, 15),
                InscriptionStartDate = new DateTime(2023, 11, 16),
                InscriptionEndDate = new DateTime(2023, 12, 15),
                ConferenceStartDate = new DateTime(2023, 12, 16),
                ConferenceEndDate = new DateTime(2023, 12, 18)
            }
        }
    
        };
    }
}
