using System.Text.Json;

namespace Tgstation.Auth.Groups
{
    /// <summary>
    /// The type of group on the /tg/station forum.
    /// </summary>
    public enum TgGroupType
    {
        Open,
        Closed,
        Hidden,
        Special,
        Free
    }
    
    /// <summary>
    /// A group as represented in the /tg/station user API.
    /// </summary>
    public class TgGroup
    {
        /// <summary>
        /// The ID of the group.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The name of the group.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// If the user who this group is on is the leader.
        /// </summary>
        public bool Leader { get; set; }
        
        /// <summary>
        /// The type of group, see <see cref="TgGroupType"/>.
        /// </summary>
        public TgGroupType Type { get; set; }

        /// <summary>
        /// Initializes a new <cref see="TgGroup"/> from a serialized version returned by the /tg/station user API.
        /// </summary>
        /// <param name="data">The serialized representation of the group</param>
        public TgGroup(JsonElement data)
        {
            Id = data.GetProperty("group_id").GetInt32();
            Name = data.GetProperty("group_name").GetString();
            Leader = data.GetProperty("group_leader").GetBoolean();
            Type = (TgGroupType)data.GetProperty("group_type").GetInt32();
        }
    }
}