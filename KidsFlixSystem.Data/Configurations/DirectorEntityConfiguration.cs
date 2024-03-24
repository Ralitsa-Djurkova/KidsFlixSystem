using KidsFlixSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFlixSystem.Data.Configurations
{
    public class DirectorEntityConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {

            builder.HasData(GetDirectir());
        }

        private Director[] GetDirectir()
        {
            ICollection<Director> directors = new List<Director>();
            Director director;

            director = new Director
            {
                Id = 1,
                FullName = "Brat Luis",
                DiteOfBirth = new DateTime(1957),
                Biography = "American director, producer, writer, animator, and voice actor.",
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3a/Brad_bird_cropped_2009.jpg",

            };
            directors.Add(director);

            director = new Director
            {
                Id = 2,
                FullName = "Bayron Howard",
                DiteOfBirth = new DateTime(1968),
                Biography = "is an American animator, character designer, story artist, film director, producer, and screenwriter. He is best known as the director of the Walt Disney Animation Studios films Bolt (2008), Tangled (2010), Zootopia (2016)," +
                " and Encanto (2021). He is the first LGBT director to win the Oscar for Best Animated Feature twice for his work on Zootopia and Encant",
                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/9/99/Byron_Howard.jpg",

            };

            directors.Add(director);

            return directors.ToArray();
        }

    }
}
