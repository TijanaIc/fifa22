using Fifa22.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Business.Layer
{
    public class GroupService : IGroupService
    {
        public IGroupRepository GroupRepository { get; }

        public GroupService(IGroupRepository groupRepository)
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
