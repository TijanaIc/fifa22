using Fifa22.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Business.Layer
{
    public class BusinessLayer : IBusinessLayer
    {
        public IGroupRepository GroupRepository { get; }

        public BusinessLayer(IGroupRepository groupRepository)
        {
            GroupRepository = groupRepository;
        }
        public List<Group> GetGroups()
        {
                var groups = GroupRepository.GetGroups();
                return groups;
        }
    }
}
