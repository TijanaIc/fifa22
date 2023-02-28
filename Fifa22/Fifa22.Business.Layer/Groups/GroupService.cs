using Fifa22.Data;
using Fifa22.Data.Repositories;

namespace Fifa22.Business.Layer.Groups
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository GroupRepository;

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
