using AAEmu.Game.Models.Game.Quests.Templates;
using AAEmu.Game.Models.Game.Char;

namespace AAEmu.Game.Models.Game.Quests.Acts
{
    public class QuestActConAcceptNpcKill : QuestActTemplate
    {
        public uint NpcId { get; set; }

        public override bool Use(Character character, Quest quest, int objective)
        {
            _log.Warn("QuestActConAcceptNpcKill: NpcId {0}", NpcId);
            return false;
        }
    }
}
