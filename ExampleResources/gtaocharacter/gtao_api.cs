using System;
using System.Linq;
using System.Collections.Generic;
using GTANetworkServer;
using GTANetworkShared;

public class GTAOnlineCharacter : Script
{
	// Exported

	public void initializePedFace(NetHandle ent)
	{
		API.setEntityData(ent, "GTAO_HAS_CHARACTER_DATA", true);

		API.setEntityData(ent, "GTAO_SHAPE_FIRST_ID", 0);
        API.setEntityData(ent, "GTAO_SHAPE_SECOND_ID", 0);
        API.setEntityData(ent, "GTAO_SKIN_FIRST_ID", 0);
        API.setEntityData(ent, "GTAO_SKIN_SECOND_ID", 0);
        API.setEntityData(ent, "GTAO_SHAPE_MIX", 0f);
        API.setEntityData(ent, "GTAO_SKIN_MIX", 0f);
        API.setEntityData(ent, "GTAO_HAIR_COLOR", 0);
        API.setEntityData(ent, "GTAO_HAIR_HIGHLIGHT_COLOR", 0);
        API.setEntityData(ent, "GTAO_EYE_COLOR", 0);
        API.setEntityData(ent, "GTAO_EYEBROWS", 0);
        API.setEntityData(ent, "GTAO_MAKEUP", 0);
        API.setEntityData(ent, "GTAO_LIPSTICK", 0);
        API.setEntityData(ent, "GTAO_EYEBROWS_COLOR", 0);
        API.setEntityData(ent, "GTAO_MAKEUP_COLOR", 0);
        API.setEntityData(ent, "GTAO_LIPSTICK_COLOR", 0);
        API.setEntityData(ent, "GTAO_EYEBROWS_COLOR2", 0);
        API.setEntityData(ent, "GTAO_MAKEUP_COLOR2", 0);
        API.setEntityData(ent, "GTAO_LIPSTICK_COLOR2", 0);

        var list = new float[21];

        for (var i = 0; i < 21; i++) {
            list[i] = 0f;
        }

        API.setEntityData(ent, "GTAO_FACE_FEATURES_LIST", list);
	}

	public void removePedFace(NetHandle ent)
	{
		API.setEntityData(ent, "GTAO_HAS_CHARACTER_DATA", false);

		API.resetEntityData(ent, "GTAO_SHAPE_FIRST_ID");
        API.resetEntityData(ent, "GTAO_SHAPE_SECOND_ID");
        API.resetEntityData(ent, "GTAO_SKIN_FIRST_ID");
        API.resetEntityData(ent, "GTAO_SKIN_SECOND_ID");
        API.resetEntityData(ent, "GTAO_SHAPE_MIX");
        API.resetEntityData(ent, "GTAO_SKIN_MIX");
        API.resetEntityData(ent, "GTAO_HAIR_COLOR");
        API.resetEntityData(ent, "GTAO_HAIR_HIGHLIGHT_COLOR");
        API.resetEntityData(ent, "GTAO_EYE_COLOR");
        API.resetEntityData(ent, "GTAO_EYEBROWS");
        API.resetEntityData(ent, "GTAO_MAKEUP");
        API.resetEntityData(ent, "GTAO_LIPSTICK");
        API.resetEntityData(ent, "GTAO_EYEBROWS_COLOR");
        API.resetEntityData(ent, "GTAO_MAKEUP_COLOR");
        API.resetEntityData(ent, "GTAO_LIPSTICK_COLOR");
        API.resetEntityData(ent, "GTAO_EYEBROWS_COLOR2");
        API.resetEntityData(ent, "GTAO_MAKEUP_COLOR2");
        API.resetEntityData(ent, "GTAO_LIPSTICK_COLOR2");
        API.resetEntityData(ent, "GTAO_FACE_FEATURES_LIST");
	}

	public bool isPlayerFaceValid(NetHandle player)
	{
		if (!API.hasEntityData(ent, "GTAO_SHAPE_FIRST_ID")) return false;
        if (!API.hasEntityData(ent, "GTAO_SHAPE_SECOND_ID")) return false;
        if (!API.hasEntityData(ent, "GTAO_SKIN_FIRST_ID")) return false;
        if (!API.hasEntityData(ent, "GTAO_SKIN_SECOND_ID")) return false;
        if (!API.hasEntityData(ent, "GTAO_SHAPE_MIX")) return false;
        if (!API.hasEntityData(ent, "GTAO_SKIN_MIX")) return false;
        if (!API.hasEntityData(ent, "GTAO_HAIR_COLOR")) return false;
        if (!API.hasEntityData(ent, "GTAO_HAIR_HIGHLIGHT_COLOR")) return false;
        if (!API.hasEntityData(ent, "GTAO_EYE_COLOR")) return false;
        if (!API.hasEntityData(ent, "GTAO_EYEBROWS")) return false;
        if (!API.hasEntityData(ent, "GTAO_MAKEUP")) return false;
        if (!API.hasEntityData(ent, "GTAO_LIPSTICK")) return false;
        if (!API.hasEntityData(ent, "GTAO_EYEBROWS_COLOR")) return false;
        if (!API.hasEntityData(ent, "GTAO_MAKEUP_COLOR")) return false;
        if (!API.hasEntityData(ent, "GTAO_LIPSTICK_COLOR")) return false;
        if (!API.hasEntityData(ent, "GTAO_EYEBROWS_COLOR2")) return false;
        if (!API.hasEntityData(ent, "GTAO_MAKEUP_COLOR2")) return false;
        if (!API.hasEntityData(ent, "GTAO_LIPSTICK_COLOR2")) return false;
        if (!API.hasEntityData(ent, "GTAO_FACE_FEATURES_LIST")) return false;

        return true;
	}

	public void updatePlayerFace(NetHandle player)
	{
		API.triggerClientEventForAll("UPDATE_CHARACTER", player);
	}
}