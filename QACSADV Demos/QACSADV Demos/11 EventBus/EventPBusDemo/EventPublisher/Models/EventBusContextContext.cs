using Microsoft.EntityFrameworkCore;

namespace EventPublisher.Models
{
    public class EventBusContextContext: DbContext
    {
        public EventBusContextContext(DbContextOptions<EventBusContextContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
