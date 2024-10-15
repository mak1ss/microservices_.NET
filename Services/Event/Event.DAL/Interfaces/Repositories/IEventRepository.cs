﻿
using EF_ServcieManagement.DAL.Entities;

namespace EF_ServcieManagement.DAL.Interfaces.Repositories
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        Task<IEnumerable<Event>> GetEventsByCategoryAsync(int categoryId);

        Task<IEnumerable<Event>> GetEventsByTagsAsync(string[] tagNames);

        Task<Event> AddTagAsync(Tag tag, int serviceId);

        Task<Event> DeleteTagAsync(int tagId, int serviceId);
        
    }
}
