using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace ModMenuSpace
{
	// Token: 0x02001604 RID: 5636
	public class ModMenu : MonoBehaviour
	{
		// Token: 0x06009430 RID: 37936
		public static void DrawMenu()
		{
			GUIStyle guistyle = new GUIStyle();
			guistyle.fontSize = 12;
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.normal.textColor = Color.white;
			guistyle.normal.background = ModMenu.MakeTexture(2, 2, new Color(0f, 0f, 0f, 0.5f));
			GUIStyle guistyle2 = new GUIStyle();
			guistyle2.fontSize = 15;
			guistyle2.alignment = TextAnchor.MiddleCenter;
			guistyle2.normal.textColor = Color.white;
			if (GUI.Button(new Rect(0f, 0f, 100f, 30f), "Cheats Menu", guistyle))
			{
				ModMenu.MenuVisible = !ModMenu.MenuVisible;
			}
			if (GUI.Button(new Rect(0f, 45f, 100f, 30f), "Items Menu", guistyle))
			{
				ModMenu.ItemMenuVisible = !ModMenu.ItemMenuVisible;
			}
			if (GUI.Button(new Rect(0f, 90f, 100f, 30f), "Prisons Menu", guistyle))
			{
				ModMenu.PrisonMenuVisible = !ModMenu.PrisonMenuVisible;
			}
			if (ModMenu.PrisonMenuVisible)
			{
				GUI.Box(new Rect(1100f, 0f, 500f, 200f), "Prisons Menu");
				if (GUI.Button(new Rect(1100f, 60f, 180f, 30f), "Center Perks", guistyle))
				{
					foreach (PrisonData prisonData2 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData2.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo = prisonData2.m_LevelInfo;
							levelInfo.m_AssociatedFile = "Centre_Perks";
							levelInfo.m_PrisonEnum = LevelScript.PRISON_ENUM.Centre_Perks;
							levelInfo.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData2.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_CentrePerks";
							prisonData2.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_CentrePerks";
							prisonData2.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_CenterPerks";
							prisonData2.m_NameLocalizationKey = "Text.Prison.Centre_Perks";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 90f, 180f, 30f), "Cougar Creek Railroad", guistyle))
				{
					foreach (PrisonData prisonData3 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData3.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo2 = prisonData3.m_LevelInfo;
							levelInfo2.m_AssociatedFile = "Transport_Train";
							levelInfo2.m_PrisonEnum = LevelScript.PRISON_ENUM.Transport_Train;
							levelInfo2.m_PrisonType = LevelScript.PRISON_TYPE.Transport;
							prisonData3.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Train";
							prisonData3.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Train";
							prisonData3.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Train";
							prisonData3.m_NameLocalizationKey = "Text.Prison.Transport_Train";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 120f, 180f, 30f), "Rattlesnake Springs", guistyle))
				{
					foreach (PrisonData prisonData4 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData4.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo3 = prisonData4.m_LevelInfo;
							levelInfo3.m_AssociatedFile = "OldWestFort";
							levelInfo3.m_PrisonEnum = LevelScript.PRISON_ENUM.OldWestFort;
							levelInfo3.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData4.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_WildWest";
							prisonData4.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_OldWest";
							prisonData4.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_OWF";
							prisonData4.m_NameLocalizationKey = "Text.Prison.OldWestFort";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 150f, 180f, 30f), "K.A.P.O.W Camp", guistyle))
				{
					foreach (PrisonData prisonData5 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData5.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo4 = prisonData5.m_LevelInfo;
							levelInfo4.m_AssociatedFile = "POW_Camp";
							levelInfo4.m_PrisonEnum = LevelScript.PRISON_ENUM.POW_Camp;
							levelInfo4.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData5.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_POW";
							prisonData5.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_POW";
							prisonData5.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_POW";
							prisonData5.m_NameLocalizationKey = "Text.Prison.POW_Camp";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 180f, 180f, 30f), "H.M.S Orca", guistyle))
				{
					foreach (PrisonData prisonData6 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData6.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo5 = prisonData6.m_LevelInfo;
							levelInfo5.m_AssociatedFile = "Transport_Boat";
							levelInfo5.m_PrisonEnum = LevelScript.PRISON_ENUM.Transport_Boat;
							levelInfo5.m_PrisonType = LevelScript.PRISON_TYPE.Transport;
							prisonData6.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Boat";
							prisonData6.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Boat";
							prisonData6.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Boat";
							prisonData6.m_NameLocalizationKey = "Text.Prison.Transport_Boat";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 210f, 180f, 30f), "H.M.P Offshore", guistyle))
				{
					foreach (PrisonData prisonData7 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData7.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo6 = prisonData7.m_LevelInfo;
							levelInfo6.m_AssociatedFile = "Oil_Rig";
							levelInfo6.m_PrisonEnum = LevelScript.PRISON_ENUM.Oil_Rig;
							levelInfo6.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData7.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_OilRig";
							prisonData7.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_OilRig";
							prisonData7.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_OilRig";
							prisonData7.m_NameLocalizationKey = "Text.Prison.Oil_Rig";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 240f, 180f, 30f), "Fort Tundra", guistyle))
				{
					foreach (PrisonData prisonData8 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData8.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo7 = prisonData8.m_LevelInfo;
							levelInfo7.m_AssociatedFile = "Gulag_Prison";
							levelInfo7.m_PrisonEnum = LevelScript.PRISON_ENUM.Gulag_Prison;
							levelInfo7.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData8.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Gulag";
							prisonData8.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Gulag";
							prisonData8.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Gulag";
							prisonData8.m_NameLocalizationKey = "Text.Prison.Gulag_Prison";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 270f, 180f, 30f), "Area 17", guistyle))
				{
					foreach (PrisonData prisonData9 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData9.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo8 = prisonData9.m_LevelInfo;
							levelInfo8.m_AssociatedFile = "Area_17";
							levelInfo8.m_PrisonEnum = LevelScript.PRISON_ENUM.Area_17;
							levelInfo8.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData9.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Area17";
							prisonData9.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Area17";
							prisonData9.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Area17";
							prisonData9.m_NameLocalizationKey = "Text.Prison.Area_17";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 300f, 180f, 30f), "Air Force Con", guistyle))
				{
					foreach (PrisonData prisonData10 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData10.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo9 = prisonData10.m_LevelInfo;
							levelInfo9.m_AssociatedFile = "Transport_Plane";
							levelInfo9.m_PrisonEnum = LevelScript.PRISON_ENUM.Transport_Plane;
							levelInfo9.m_PrisonType = LevelScript.PRISON_TYPE.Transport;
							prisonData10.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Plane";
							prisonData10.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Plane";
							prisonData10.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Plane";
							prisonData10.m_NameLocalizationKey = "Text.Prison.Transport_Plane";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 330f, 180f, 30f), "U.S.S Anomaly", guistyle))
				{
					foreach (PrisonData prisonData11 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData11.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo10 = prisonData11.m_LevelInfo;
							levelInfo10.m_AssociatedFile = "Space Prison";
							levelInfo10.m_PrisonEnum = LevelScript.PRISON_ENUM.Space_Prison;
							levelInfo10.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData11.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Space";
							prisonData11.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Space";
							prisonData11.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Space";
							prisonData11.m_NameLocalizationKey = "Text.Prison.Space_Prison";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 360f, 180f, 30f), "The Glorious Regime", guistyle))
				{
					foreach (PrisonData prisonData12 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData12.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo11 = prisonData12.m_LevelInfo;
							levelInfo11.m_AssociatedFile = "Dictator_Prison";
							levelInfo11.m_PrisonEnum = LevelScript.PRISON_ENUM.Dictator;
							levelInfo11.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData12.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_DictatorVillage";
							prisonData12.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_Dictator";
							prisonData12.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_Dictator";
							prisonData12.m_NameLocalizationKey = "Text.Prison.Dictator";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 390f, 180f, 30f), "Wicked Ward", guistyle))
				{
					foreach (PrisonData prisonData13 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData13.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo12 = prisonData13.m_LevelInfo;
							levelInfo12.m_AssociatedFile = "Halloween_Prison";
							levelInfo12.m_PrisonEnum = LevelScript.PRISON_ENUM.DLC02;
							levelInfo12.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData13.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_Asylum";
							prisonData13.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_WickedWard";
							prisonData13.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_WickedWard";
							prisonData13.m_NameLocalizationKey = "Text.Menu.DLCName02";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 420f, 180f, 30f), "Santa's Shakedown", guistyle))
				{
					foreach (PrisonData prisonData14 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData14.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo13 = prisonData14.m_LevelInfo;
							levelInfo13.m_AssociatedFile = "DLC03_Prison";
							levelInfo13.m_PrisonEnum = LevelScript.PRISON_ENUM.DLC03;
							levelInfo13.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData14.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_DLC03";
							prisonData14.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_DLC03";
							prisonData14.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_DLC03";
							prisonData14.m_NameLocalizationKey = "Text.Menu.DLCName03";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 450f, 180f, 30f), "Big Top Breakout", guistyle))
				{
					foreach (PrisonData prisonData15 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData15.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo14 = prisonData15.m_LevelInfo;
							levelInfo14.m_AssociatedFile = "DLC04_Prison";
							levelInfo14.m_PrisonEnum = LevelScript.PRISON_ENUM.DLC04;
							levelInfo14.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData15.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_DLC04";
							prisonData15.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_DLC04";
							prisonData15.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_DLC04";
							prisonData15.m_NameLocalizationKey = "Text.Menu.DLCName04";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 480f, 180f, 30f), "Dungeons And Duct Tape", guistyle))
				{
					foreach (PrisonData prisonData16 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData16.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo15 = prisonData16.m_LevelInfo;
							levelInfo15.m_AssociatedFile = "DLC05_Prison";
							levelInfo15.m_PrisonEnum = LevelScript.PRISON_ENUM.DLC05;
							levelInfo15.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData16.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_DLC05";
							prisonData16.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_DLC05";
							prisonData16.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_DLC05";
							prisonData16.m_NameLocalizationKey = "Text.Menu.DLCName05";
						}
					}
				}
				if (GUI.Button(new Rect(1100f, 510f, 180f, 30f), "Snow Way Out", guistyle))
				{
					foreach (PrisonData prisonData17 in (PrisonData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(PrisonData)))
					{
						if (prisonData17.name == "CenterPerks_FrontendLevelData")
						{
							PrisonData.LevelInfo levelInfo16 = prisonData17.m_LevelInfo;
							levelInfo16.m_AssociatedFile = "DLC06_Prison";
							levelInfo16.m_PrisonEnum = LevelScript.PRISON_ENUM.DLC06;
							levelInfo16.m_PrisonType = LevelScript.PRISON_TYPE.Normal;
							prisonData17.m_ImagePath = "LevelPreviewImages/FE_LevelPreview_DLC06";
							prisonData17.m_PrisonSetupImagePath = "LevelPreviewImages/FE_SetUpMenu_RollCallBacking_DLC06";
							prisonData17.m_RoundResultsImagePath = "RoundResultsImages/FE_Roundscore_DLC06";
							prisonData17.m_NameLocalizationKey = "Text.Menu.DLCName06";
						}
					}
				}
			}
			if (ModMenu.ItemMenuVisible)
			{
				GUI.Box(new Rect(600f, 0f, 500f, 400f), "Items Menu");
				ModMenu.stringGiveItemToPlayer = GUI.TextField(new Rect(600f, 30f, 180f, 30f), ModMenu.stringGiveItemToPlayer, 50, guistyle);
				if (GUI.Button(new Rect(600f, 60f, 180f, 30f), "Give Item: Name", guistyle))
				{
					foreach (Item item in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						MonoBehaviour.print("found all items");
						if (item.ItemName == "No ItemData Set")
						{
							foreach (ItemData itemData in (ItemData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(ItemData)))
							{
								if (itemData.name == ModMenu.stringGiveItemToPlayer + "_ItemData")
								{
									MonoBehaviour.print("found");
									item.m_ItemData = itemData;
									item.name = itemData.m_ItemLocalizationTag + "_JkoCustom";
									T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>().AddItemRPC(item, false, RPC_CallContexts.All);
								}
							}
							break;
						}
					}
				}
				ModMenu.intItemDataIDPlayerWants = GUI.TextField(new Rect(600f, 100f, 180f, 30f), ModMenu.intItemDataIDPlayerWants, 25, guistyle);
				if (GUI.Button(new Rect(600f, 130f, 180f, 30f), "Give item: ID", guistyle))
				{
					foreach (Item item2 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						MonoBehaviour.print("found all items");
						if (item2.ItemName == "No ItemData Set")
						{
							MonoBehaviour.print("found unused items");
							foreach (ItemData itemData2 in (ItemData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(ItemData)))
							{
								if (itemData2.m_ItemDataID == int.Parse(ModMenu.intItemDataIDPlayerWants))
								{
									MonoBehaviour.print("found");
									item2.m_ItemData = itemData2;
									item2.name = itemData2.m_ItemLocalizationTag + "_JkoCustom";
									T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>().AddItemRPC(item2, false, RPC_CallContexts.All);
								}
							}
							break;
						}
					}
				}
			}
			if (ModMenu.MenuVisible)
			{
				GUI.Box(new Rect(100f, 0f, 500f, 400f), "TE2UMM");
				GUI.Label(new Rect(100f, 0f, 180f, 30f), "Player Cheats", guistyle2);
				GUI.Label(new Rect(400f, 0f, 180f, 30f), "Prison Cheats", guistyle2);
				GUI.Label(new Rect(400f, 170f, 180f, 30f), "Map Editor Cheats", guistyle2);
				if (GUI.Button(new Rect(100f, 30f, 180f, 30f), ModMenu.MaxPlayerStatsLabel, guistyle))
				{
					ConfigManager instance = ConfigManager.GetInstance();
					CharacterStats component4 = T17NetView.Find<Player>(2974).gameObject.GetComponent<CharacterStats>();
					component4.SetHealth(1000f);
					component4.SetEnergy(1000f);
					component4.SetHeat(0f, CharacterStats.MessageGameplayReasons.Unassigned);
					component4.IncreaseMoney(1000000f);
					component4.IncreaseIntellectRPC(1000f);
					component4.IncreaseStrengthRPC(1000f);
					component4.IncreaseCardioRPC(1000f);
					component4.IncreaseEnergyRPC(1000f);
					component4.IncreaseHealthRPC(1000f);
					if (instance != null)
					{
						CharacterConfig playerConfig = instance.playerConfig;
						playerConfig.m_HealthBaseLine = 1000f;
						playerConfig.m_StrengthBaseLine = 1000f;
						playerConfig.m_CardioBaseLine = 1000f;
						playerConfig.m_IntellectBaseLine = 1000f;
						playerConfig.m_EnergyBaseLine = 1000f;
						playerConfig.m_MoneyBaseLine = 99999f;
						playerConfig.m_HealthRestoreRate = 100f;
						playerConfig.m_EnergyRestoreRate = 100f;
						playerConfig.m_EnergyRestoreRateBlocking = 100f;
						playerConfig.m_StrengthDecayRate = 0f;
						playerConfig.m_IntellectDecayRate = 0f;
						playerConfig.m_CardioDecayRate = 0f;
						playerConfig.m_HeatDecayRate = 1000f;
					}
				}
				if (GUI.Button(new Rect(100f, 60f, 180f, 30f), ModMenu.NoclipLabel, guistyle))
				{
					ModMenu.NoclipActive = !ModMenu.NoclipActive;
					Rigidbody component2 = T17NetView.Find<Player>(2974).gameObject.GetComponent<Rigidbody>();
					if (ModMenu.NoclipActive)
					{
						ModMenu.NoclipLabel = "Noclip ON";
						component2.detectCollisions = false;
					}
					else
					{
						ModMenu.NoclipLabel = "Noclip OFF";
						component2.detectCollisions = true;
					}
				}
				if (GUI.Button(new Rect(100f, 90f, 180f, 30f), ModMenu.SpeedHackLabel, guistyle))
				{
					ModMenu.SpeedHackActive = !ModMenu.SpeedHackActive;
					CharacterMovement component3 = T17NetView.Find<Player>(2974).gameObject.GetComponent<CharacterMovement>();
					if (ModMenu.SpeedHackActive)
					{
						ModMenu.SpeedHackLabel = "SpeedHack ON";
						component3.m_fMaxSpeed = 15f;
					}
					else
					{
						ModMenu.SpeedHackLabel = "SpeedHack OFF";
						component3.m_fMaxSpeed = 4.7f;
					}
				}
				if (GUI.Button(new Rect(100f, 120f, 180f, 30f), ModMenu.UnlockDoorsLabel, guistyle))
				{
					ModMenu.UnlockDoorsLabel = "Open Every Doors";
					foreach (Door door in UnityEngine.Object.FindObjectsOfType<Door>())
					{
						T17NetView.Find<Player>(2974).AddAllowedDoor(door, null);
						door.SetForceOpen(true);
						DoorManager.GetInstance().SetUpCharacterKeys(T17NetView.Find<Player>(2974));
					}
				}
				if (GUI.Button(new Rect(400f, 30f, 180f, 30f), ModMenu.LockdownLabel, guistyle))
				{
					ModMenu.LockdownActive = !ModMenu.LockdownActive;
					PrisonAlertnessManager instance2 = PrisonAlertnessManager.GetInstance();
					if (instance2 != null)
					{
						if (ModMenu.LockdownActive)
						{
							try
							{
								SolitaryManager.GetInstance().TriggerLockdown(false);
								Debug.LogWarning("[Trainer] Toggle Lockdown to Active: " + instance2.GetCurrentAlertness().ToString());
							}
							catch (Exception ex)
							{
								Debug.LogError("[Trainer] Lockdown ERROR: " + ex.Message);
							}
						}
						try
						{
							SolitaryManager.GetInstance().GetType().GetMethod("OnAlarm_LockdownEnd", ModMenu.defaultBindingFlags).Invoke(SolitaryManager.GetInstance(), null);
							SolitaryManager.GetInstance().GetType().GetField("m_bIsLockdownActive", ModMenu.fieldBindingFlags).SetValue(SolitaryManager.GetInstance(), false);
							SolitaryManager.GetInstance().GetType().GetField("m_LockdownTimer", ModMenu.fieldBindingFlags).SetValue(SolitaryManager.GetInstance(), null);
							instance2.StopCoroutine("HUD.Routine.Lockdown");
							Debug.LogWarning("[Trainer] Toggle Lockdown to Inactive: " + instance2.GetCurrentAlertness().ToString());
						}
						catch (Exception ex2)
						{
							Debug.LogError("[Trainer] Lockdown ERROR: " + ex2.Message);
						}
					}
				}
				if (GUI.Button(new Rect(400f, 60f, 180f, 30f), ModMenu.DogLabel, guistyle))
				{
					DogEventManager dogEventManager = UnityEngine.Object.FindObjectOfType<DogEventManager>();
					if (dogEventManager != null)
					{
						foreach (AICharacter aicharacter in NPCManager.GetInstance().m_Doggies)
						{
							AICharacter_Dog aicharacter_Dog = (AICharacter_Dog)aicharacter;
							aicharacter_Dog.ForgetEvent(dogEventManager.GetAttackingAIEvent());
							aicharacter_Dog.ForgetEvent(dogEventManager.GetBoundAIEvent());
							aicharacter_Dog.ForgetEvent(dogEventManager.GetKnockedOutAIEvent());
							aicharacter_Dog.m_Character.SetIsAttacking(false);
							aicharacter_Dog.m_Character.PauseMovement(1000f, true);
							aicharacter_Dog.m_Character.m_CharacterOpinions.IncreaseOpinionOf(T17NetView.Find<Player>(2974), 1000);
						}
						dogEventManager.IsAttacking(false);
						dogEventManager.IsBound(false, T17NetView.Find<Player>(2974));
						Debug.Log("[Trainer] Call Off Dogs");
					}
				}
				if (GUI.Button(new Rect(400f, 90f, 180f, 30f), ModMenu.HittableDogsLabel, guistyle))
				{
					ModMenu.HittableDogsActive = !ModMenu.HittableDogsActive;
					UnityEngine.Object.FindObjectOfType<DogEventManager>();
					if (ModMenu.HittableDogsActive)
					{
						ModMenu.HittableDogsLabel = "Hittable Dogs ON";
						using (List<AICharacter>.Enumerator enumerator2 = NPCManager.GetInstance().m_Doggies.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								AICharacter aicharacter2 = enumerator2.Current;
								((AICharacter_Dog)aicharacter2).gameObject.GetComponent<AIPlayer>().m_CharacterRole = CharacterRole.Inmate;
							}
							return;
						}
					}
					ModMenu.HittableDogsLabel = "Hittable Dogs OFF";
					foreach (AICharacter aicharacter3 in NPCManager.GetInstance().m_Doggies)
					{
						((AICharacter_Dog)aicharacter3).gameObject.GetComponent<AIPlayer>().m_CharacterRole = CharacterRole.Dog;
					}
				}
				if (GUI.Button(new Rect(400f, 120f, 180f, 30f), ModMenu.ElectricFencesLabel, guistyle))
				{
					ModMenu.ElectricFencesActive = !ModMenu.ElectricFencesActive;
					PrisonPowerManager instance3 = PrisonPowerManager.GetInstance();
					if (instance3 != null)
					{
						List<PrisonPowerManager.GeneratorData> generators = instance3.m_Generators;
						for (int i = 0; i < generators.Count; i++)
						{
							List<ElectricFence> electricFences = generators.ElementAt(i).m_ElectricFences;
							for (int j = 0; j < electricFences.Count; j++)
							{
								ElectricFence electricFence = electricFences.ElementAt(j);
								electricFence.SetEnabled(ModMenu.ElectricFencesActive);
								Debug.LogWarning("[Trainer] Electric Fence State Change: " + electricFence.gameObject.name);
							}
						}
					}
				}
				if (GUI.Button(new Rect(400f, 200f, 180f, 30f), "[E] Force Validate Zones", guistyle))
				{
					LevelEditor_ZoneManager.GetInstance().GetInvalidZonesInLayer(BaseLevelManager.LevelLayers.GroundFloor, ref ModMenu.Test).m_bValid = true;
					MonoBehaviour.print("yes");
				}
				if (GUI.Button(new Rect(100f, 210f, 180f, 30f), "Unlock every Doors", guistyle))
				{
					foreach (Door door2 in UnityEngine.Object.FindObjectsOfType<Door>())
					{
						door2.gameObject.GetComponent<BoxCollider>().enabled = false;
						T17NetView.Find<Player>(2974).AddAllowedDoor(door2, null);
					}
				}
				if (GUI.Button(new Rect(400f, 230f, 180f, 30f), "[E] Bypass Requirements", guistyle))
				{
					foreach (ZoneDetailsManager.ZoneDetails zoneDetails in UnityEngine.Object.FindObjectOfType<ZoneDetailsManager>().m_Zones)
					{
						MonoBehaviour.print("yes");
						foreach (ZoneRequirement zoneRequirement in zoneDetails.m_Requirements)
						{
							zoneRequirement.m_Minimum.m_MinimumValue = 0;
							zoneRequirement.m_Minimum.m_MaximumValue = 5000;
							zoneRequirement.m_Minimum.m_Type = LimitValue.LimitType.UNKNOWN;
							zoneRequirement.m_Maximum.m_MaximumValue = 5000;
							zoneRequirement.m_Maximum.m_Type = LimitValue.LimitType.UNKNOWN;
						}
					}
				}
				if (GUI.Button(new Rect(100f, 240f, 180f, 30f), "All NPC Hittable", guistyle))
				{
					AIPlayer[] array4 = UnityEngine.Object.FindObjectsOfType<AIPlayer>();
					for (int k = 0; k < array4.Length; k++)
					{
						array4[k].m_CharacterRole = CharacterRole.Inmate;
					}
				}
				ModMenu.changeFloor = GUI.TextField(new Rect(100f, 270f, 180f, 30f), ModMenu.changeFloor, 25, guistyle);
				if (GUI.Button(new Rect(100f, 300f, 180f, 30f), "Change Floor", guistyle))
				{
					foreach (FloorManager.Floor floor in FloorManager.GetInstance().m_PrisonFloors)
					{
						if (floor.m_FloorName == ModMenu.changeFloor)
						{
							T17NetView.Find<Player>(2974).Teleport(T17NetView.Find<Player>(2974).m_CachedCurrentPosition, floor, true);
							T17NetView.Find<Player>(2974).gameObject.GetComponent<CharacterSpeechBubbleHandler>().NewSpeech("Teleported  " + T17NetView.Find<Player>(2974).name + " to " + ModMenu.changeFloor, SpeechTone.Positive, 3f, 10, true);
						}
					}
				}
				if (GUI.Button(new Rect(100f, 330f, 180f, 30f), "Free craft", guistyle))
				{
					CraftManager instance4 = CraftManager.GetInstance();
					if (instance4 != null)
					{
						List<CraftManager.Recipe> currentRecipes = instance4.GetCurrentRecipes();
						for (int num2 = 0; num2 < currentRecipes.Count; num2++)
						{
							currentRecipes.ElementAt(num2).m_Ingredients = new ItemData[3];
						}
					}
				}
				if (GUI.Button(new Rect(100f, 360f, 180f, 30f), "Add Crafting Recipes", guistyle) && CraftManager.GetInstance() != null)
				{
					foreach (ItemData itemData3 in (ItemData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(ItemData)))
					{
						if (itemData3.name == ModMenu.stringGiveItemToPlayer + "_ItemData")
						{
							CraftManager.Recipe recipe = new CraftManager.Recipe();
							List<ItemData> allowedList = ItemManager.GetInstance().GetAllowedList();
							List<CraftManager.Recipe> currentRecipes2 = CraftManager.GetInstance().GetCurrentRecipes();
							recipe.m_bDiscovered = true;
							recipe.m_bHidden = false;
							recipe.m_Product = itemData3;
							recipe.m_Intellect = 70;
							recipe.m_CraftedCount = ++ModMenu.Additionned;
							currentRecipes2.Add(recipe);
							allowedList.Add(itemData3);
							ModMenu.Additionned++;
							T17NetView.Find<Player>(2974).gameObject.GetComponent<CharacterSpeechBubbleHandler>().NewSpeech("Added recipe for  " + recipe.m_Product.name, SpeechTone.Positive, 3f, 10, true);
						}
					}
				}
			}
		}

		// Token: 0x06009432 RID: 37938
		static ModMenu()
		{
			ModMenu.MenuLabel = "TE2 Ultimate Mod Menu";
			ModMenu.MenuVisible = false;
			ModMenu.PrisonMenuVisible = false;
			ModMenu.ItemMenuVisible = false;
			ModMenu.MaxPlayerStatsLabel = "Max Player Stats";
			ModMenu.NoclipActive = false;
			ModMenu.NoclipLabel = "Noclip OFF";
			ModMenu.SpeedHackActive = false;
			ModMenu.SpeedHackLabel = "SpeedHack OFF";
			ModMenu.UnlockDoorsLabel = "Open Every Doors";
			ModMenu.LockdownLabel = "Lockdown OFF";
			ModMenu.LockdownActive = false;
			ModMenu.DogLabel = "Disable Dogs";
			ModMenu.GiveLabel = "Give Destroy Wall Tool";
			ModMenu.GiveStaffKeyLabel = "Give Staff Key";
			ModMenu.HittableDogsLabel = "Hittable Dogs OFF";
			ModMenu.ElectricFencesActive = false;
			ModMenu.ElectricFencesLabel = "Electric Fences";
			ModMenu.stringGiveItemToPlayer = "PlaceHolder";
			ModMenu.changeFloor = "eg. Floor0";
			ModMenu.Test = 0;
			ModMenu.Additionned = 6;
			ModMenu.SearchedPlayerWantedItemWithItemdata = false;
			ModMenu.SearchAllItemData = false;
			ModMenu.SearchedAllItem = false;
			ModMenu.Searchedallitemnameforunused = false;
			ModMenu.intItemDataIDPlayerWants = "ID eg. 254";
		}

		// Token: 0x06009433 RID: 37939
		private static Texture2D MakeTexture(int width, int height, Color color)
		{
			Color[] array = new Color[width * height];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = color;
			}
			Texture2D texture2D = new Texture2D(width, height);
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x040070FD RID: 28925
		public static string MenuLabel;

		// Token: 0x040070FE RID: 28926
		public static bool MenuVisible;

		// Token: 0x040070FF RID: 28927
		public static string MaxPlayerStatsLabel;

		// Token: 0x04007100 RID: 28928
		public static bool NoclipActive;

		// Token: 0x04007101 RID: 28929
		public static string NoclipLabel;

		// Token: 0x04007102 RID: 28930
		public static bool SpeedHackActive;

		// Token: 0x04007103 RID: 28931
		public static string SpeedHackLabel;

		// Token: 0x04007104 RID: 28932
		public static string UnlockDoorsLabel;

		// Token: 0x04007105 RID: 28933
		public static string LockdownLabel;

		// Token: 0x04007106 RID: 28934
		public static bool LockdownActive;

		// Token: 0x04007107 RID: 28935
		public static BindingFlags defaultBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x04007108 RID: 28936
		public static BindingFlags fieldBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField;

		// Token: 0x04007109 RID: 28937
		public static BindingFlags propertyBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty;

		// Token: 0x0400710A RID: 28938
		public static string DogLabel;

		// Token: 0x0400710B RID: 28939
		public static string HittableDogsLabel;

		// Token: 0x0400710C RID: 28940
		public static bool HittableDogsActive;

		// Token: 0x0400710D RID: 28941
		public static string GiveLabel;

		// Token: 0x0400710E RID: 28942
		public static bool GaveItem = false;

		// Token: 0x0400710F RID: 28943
		public static string GiveStaffKeyLabel;

		// Token: 0x04007110 RID: 28944
		public static string ElectricFencesLabel;

		// Token: 0x04007111 RID: 28945
		public static bool ElectricFencesActive = false;

		// Token: 0x04007112 RID: 28946
		public static int Test;

		// Token: 0x04007113 RID: 28947
		public static bool ItemMenuVisible;

		// Token: 0x04007114 RID: 28948
		public static int Additionned;

		// Token: 0x04007115 RID: 28949
		public static string stringGiveItemToPlayer;

		// Token: 0x04007116 RID: 28950
		public static string changeFloor;

		// Token: 0x04007117 RID: 28951
		public static PhotonMessageInfo photonMessageInfo;

		// Token: 0x04007118 RID: 28952
		public static bool SearchedPlayerWantedItemWithItemdata;

		// Token: 0x04007119 RID: 28953
		public static bool SearchAllItemData;

		// Token: 0x0400711A RID: 28954
		public static bool SearchedAllItem;

		// Token: 0x0400711B RID: 28955
		public static bool Searchedallitemnameforunused;

		// Token: 0x0400711C RID: 28956
		public static string intItemDataIDPlayerWants;

		// Token: 0x0400711D RID: 28957
		public static string prisonPW;

		// Token: 0x04007120 RID: 28960
		public static bool PrisonMenuVisible;
	}
}
