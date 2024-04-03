using KidsFlixSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KidsFlixSystem.Data.Configurations
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(GetActor());
        }

        private Actor[] GetActor()
        {
            ICollection<Actor> actors = new List<Actor>();
            Actor actor;

            actor = new Actor
            {
                Id = 1,
                FullName = "Brat Garett",
                PhotoUrl = "https://www.imdb.com/name/nm0004951/mediaviewer/rm733221376/?ref_=nm_ov_ph"
            };
            actors.Add(actor);
            actor = new Actor
            {
                Id = 2,
                FullName = "Lou Romano",
                PhotoUrl = "https://www.imdb.com/name/nm0738918/mediaviewer/rm3395136000/?ref_=nm_ov_ph"
            };
            actors.Add(actor);
            actor = new Actor
            {
                Id = 3,
                FullName = "Patton Oswalt",
                PhotoUrl = "https://www.imdb.com/name/nm0652663/mediaviewer/rm532898048/?ref_=nm_ov_ph"
            };
            actors.Add(actor);

            actor = new Actor
            {
                Id = 5,
                FullName = "Ginnifer Goodwin",
                PhotoUrl = "https://www.imdb.com/name/nm0329481/mediaviewer/rm1880188672/?ref_=nm_ov_ph"
            };
            actors.Add(actor);
            actor = new Actor
            {
                Id = 6,
                FullName = "Jason Bateman",
                PhotoUrl = "https://www.imdb.com/name/nm0000867/mediaviewer/rm2064810496/?ref_=nm_ov_ph"
            };
            actors.Add(actor);
            actor = new Actor
            {
                Id = 7,
                FullName = "Idris Elba",
                PhotoUrl = "https://www.imdb.com/name/nm0252961/mediaviewer/rm1950723072/?ref_=nm_ov_ph"
            };
            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
