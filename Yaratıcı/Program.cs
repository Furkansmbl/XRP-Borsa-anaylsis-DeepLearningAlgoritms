using System;
using System.Collections.Generic;

namespace CareerPathFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var questions = new List<(string, string)>
            {
                ("Yeni fikirler ve ürünler geliştirmekten hoşlanır mısınız?", "AR-GE"),
                ("Sorunları çözmek için yaratıcı yöntemler bulmak size keyif verir mi?", "AR-GE"),
                ("Detaylı araştırma ve analiz yapmaktan zevk alır mısınız?", "AR-GE"),
                ("Projeleri planlama ve yönetme konusunda kendinize güvenir misiniz?", "Proje Yönetimi"),
                ("Bir takımın liderliğini üstlenmekten hoşlanır mısınız?", "Proje Yönetimi"),
                ("Zamanı ve kaynakları verimli bir şekilde yönetmek sizin için önemli midir?", "Proje Yönetimi"),
                ("Üretim süreçlerini optimize etmek ve geliştirmek ilginizi çeker mi?", "Üretim ve İmalat"),
                ("Makine ve ekipmanlarla çalışmaktan keyif alır mısınız?", "Üretim ve İmalat"),
                ("Süreçlerin verimliliğini artırmak için analiz yapmaktan hoşlanır mısınız?", "Üretim ve İmalat"),
                ("Bilgisayar programlama ve yazılım geliştirme ilginizi çeker mi?", "IT ve Yazılım"),
                ("Bilgi sistemlerinin analiz ve tasarımında çalışmaktan zevk alır mısınız?", "IT ve Yazılım"),
                ("Teknolojik yenilikleri takip etmek ve uygulamak sizin için heyecan verici midir?", "IT ve Yazılım"),
                ("Ürün ve hizmetlerin kalitesini sağlamak ve artırmak ilginizi çeker mi?", "Kalite Kontrol"),
                ("Detaylara dikkat ederek hata tespiti yapmaktan hoşlanır mısınız?", "Kalite Kontrol"),
                ("Standartlara ve prosedürlere uyumu denetlemek size keyif verir mi?", "Kalite Kontrol"),
                ("Tedarikçilerle pazarlık yaparak en iyi fiyatları elde etmek ilginizi çeker mi?", "Satın Alma"),
                ("Malzeme ve hizmet tedarik süreçlerini yönetmekten hoşlanır mısınız?", "Satın Alma"),
                ("Pazar araştırması yaparak en iyi tedarikçileri belirlemek size keyif verir mi?", "Satın Alma")
            };

           
            var random = new Random();
            questions.Sort((a, b) => random.Next(-1, 2));

            // Puanlar
            var scores = new Dictionary<string, int>
            {
                { "AR-GE", 0 },
                { "Proje Yönetimi", 0 },
                { "Üretim ve İmalat", 0 },
                { "IT ve Yazılım", 0 },
                { "Kalite Kontrol", 0 },
                { "Satın Alma", 0 }
            };

            Console.WriteLine("Her soruya 1-5 arası puan veriniz. (1: En düşük, 5: En yüksek)");

            // Soruları sor ve puanları topla
            foreach (var (question, department) in questions)
            {
                int score = AskQuestion(question);
                scores[department] += score;
            }

            // En yüksek puanı bul
            string maxDepartment = null;
            int maxScore = -1;
            foreach (var (department, score) in scores)
            {
                if (score > maxScore)
                {
                    maxScore = score;
                    maxDepartment = department;
                }
            }

            // Yönlendirme
            Console.WriteLine($"Sizi en çok ilgilendiren alan: {maxDepartment}");
        }

        static int AskQuestion(string question)
        {
            Console.WriteLine(question);
            int score = int.Parse(Console.ReadLine());
            return score;
        }
    }
}