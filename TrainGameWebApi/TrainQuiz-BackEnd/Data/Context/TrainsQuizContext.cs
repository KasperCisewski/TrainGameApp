using Microsoft.EntityFrameworkCore;
using TrainQuiz_BackEnd.Data.Entities;

namespace TrainQuiz_BackEnd.Data.Context
{
    public class TrainsQuizContext : DbContext, ITrainsQuizContext
    {
        public DbSet<Data.Entities.Route> Route { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Train> Train { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Point> Point { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<SectionRoute> SectionRoute { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SectionRoute>().HasKey(sr => new { sr.SectionId, sr.RouteId });
        }
        public TrainsQuizContext(DbContextOptions<TrainsQuizContext> options) : base(options)
        {
        }
    }
}
