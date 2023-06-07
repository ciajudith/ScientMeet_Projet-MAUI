using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMaui.Services
{
    public class ConferenceDataService
    {
        public async Task<IEnumerable<Conference>> GetItems()
        {
            await Task.Delay(1000); // Artifical delay to give the impression of work
            return listOfConference;
        }
            public List<Conference> listOfConference = new List<Conference>()
        {
            new Conference()
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
            new Conference()
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
            new Conference()
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
            new Conference()
            {
                Id = 4,
                Name = "Conférence sur la médecine régénérative",
                Sigle = "CONF-MR",
                Theme = "Avancées récentes en médecine régénérative",
                SubmissionStartDate = new DateTime(2023, 4, 1),
                SubmissionEndDate = new DateTime(2023, 5, 1),
                ResultsDate = new DateTime(2023, 5, 15),
                InscriptionStartDate = new DateTime(2023, 5, 16),
                InscriptionEndDate = new DateTime(2023, 6, 15),
                ConferenceStartDate = new DateTime(2023, 6, 16),
                ConferenceEndDate = new DateTime(2023, 6, 18)
            },
            new Conference()
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
            new Conference()
            {
                Id = 6,
                Name = "Conférence sur la neurologie",
                Sigle = "CONF-NEURO",
                Theme = "Avancées récentes en neurologie",
                SubmissionStartDate = new DateTime(2023, 6, 1),
                SubmissionEndDate = new DateTime(2023, 7, 1),
                ResultsDate = new DateTime(2023, 7, 15),
                InscriptionStartDate = new DateTime(2023, 7, 16),
                InscriptionEndDate = new DateTime(2023, 8, 15),
                ConferenceStartDate = new DateTime(2023, 8, 16),
                ConferenceEndDate = new DateTime(2023, 8, 18)
            },
            new Conference()
            {
                Id = 7,
                Name = "Conférence sur la génétique",
                Sigle = "CONF-GEN",
                Theme = "Découvertes récentes en génétique",
                SubmissionStartDate = new DateTime(2023, 7, 1),
                SubmissionEndDate = new DateTime(2023, 8, 1),
                ResultsDate = new DateTime(2023, 8, 15),
                InscriptionStartDate = new DateTime(2023, 8, 16),
                InscriptionEndDate = new DateTime(2023, 9, 15),
                ConferenceStartDate = new DateTime(2023, 9, 16),
                ConferenceEndDate = new DateTime(2023, 9, 18)
            },
            new Conference()
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
            new Conference()
            {
                Id = 9,
                Name = "Conférence sur la géologie",
                Sigle = "CONF-GEO",
                Theme = "Avancées récentes en géologie",
                SubmissionStartDate = new DateTime(2023, 9, 1),
                SubmissionEndDate = new DateTime(2023, 10, 1),
                ResultsDate = new DateTime(2023, 10, 15),
                InscriptionStartDate = new DateTime(2023, 10, 16),
                InscriptionEndDate = new DateTime(2023, 11, 15),
                ConferenceStartDate = new DateTime(2023, 11, 16),
                ConferenceEndDate = new DateTime(2023, 11, 18)
            },
            new Conference()
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
        };

    }
}
