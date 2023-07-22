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
			GUIStyle labelStyle = new GUIStyle();
			labelStyle.fontSize = 15;
			labelStyle.alignment = TextAnchor.MiddleCenter;
			labelStyle.normal.textColor = Color.white;
			if (GUI.Button(new Rect(0f, 0f, 100f, 30f), "Cheats Menu", guistyle))
			{
				ModMenu.MenuVisible = !ModMenu.MenuVisible;
			}
			if (GUI.Button(new Rect(0f, 45f, 100f, 30f), "Items Menu", guistyle))
			{
				ModMenu.ItemMenuVisible = !ModMenu.ItemMenuVisible;
			}
			if (ModMenu.ItemMenuVisible)
			{
				GUI.Box(new Rect(600f, 0f, 500f, 400f), "Items Menu");
				ModMenu.stringGiveItemToPlayer = GUI.TextField(new Rect(600f, 30f, 180f, 30f), ModMenu.stringGiveItemToPlayer, 50, guistyle);
				if (GUI.Button(new Rect(600f, 60f, 180f, 30f), "Give Item: Name", guistyle))
				{
					foreach (Item item4 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						MonoBehaviour.print("found all items");
						if (item4.ItemName == "No ItemData Set")
						{
							foreach (ItemData itemData8 in (ItemData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(ItemData)))
							{
								if (itemData8.name == ModMenu.stringGiveItemToPlayer + "_ItemData")
								{
									MonoBehaviour.print("found");
									item4.m_ItemData = itemData8;
									T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>().AddItemRPC(item4, false, RPC_CallContexts.All);
								}
							}
							break;
						}
					}
				}
				ModMenu.intItemDataIDPlayerWants = GUI.TextField(new Rect(600f, 100f, 180f, 30f), ModMenu.intItemDataIDPlayerWants, 25, guistyle);
				if (GUI.Button(new Rect(600f, 130f, 180f, 30f), "Give item: ID", guistyle))
				{
					foreach (Item item5 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						MonoBehaviour.print("found all items");
						if (item5.ItemName == "No ItemData Set")
						{
							MonoBehaviour.print("found unused items");
							foreach (ItemData itemData9 in (ItemData[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(ItemData)))
							{
								if (itemData9.m_ItemDataID == int.Parse(ModMenu.intItemDataIDPlayerWants))
								{
									MonoBehaviour.print("found");
									item5.m_ItemData = itemData9;
									T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>().AddItemRPC(item5, false, RPC_CallContexts.All);
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
				GUI.Label(new Rect(100f, 0f, 180f, 30f), "Player Cheats", labelStyle);
				GUI.Label(new Rect(400f, 0f, 180f, 30f), "Prison Cheats", labelStyle);
				GUI.Label(new Rect(400f, 170f, 180f, 30f), "Map Editor Cheats", labelStyle);
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
				if (GUI.Button(new Rect(100f, 150f, 180f, 30f), ModMenu.GiveLabel, guistyle))
				{
					ModMenu.GiveLabel = "Give Destroy Wall Tool";
					foreach (Item item6 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						if (item6.ItemName == "Text.Item.MaintenanceSwissDestroy" && !ModMenu.GaveItem)
						{
							ModMenu.GaveItem = true;
							T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>().AddItemRPC(item6, false, RPC_CallContexts.All);
						}
					}
					ModMenu.GaveItem = false;
				}
				if (GUI.Button(new Rect(100f, 180f, 180f, 30f), ModMenu.GiveStaffKeyLabel, guistyle))
				{
					ModMenu.GiveStaffKeyLabel = "Give Staff Key";
					foreach (Item item7 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						if (item7.ItemName == "Text.Item.StaffKey" && !ModMenu.GaveItem)
						{
							ModMenu.GaveItem = true;
							T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>().AddItemRPC(item7, false, RPC_CallContexts.All);
						}
					}
					ModMenu.GaveItem = false;
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
					AIPlayer[] array6 = UnityEngine.Object.FindObjectsOfType<AIPlayer>();
					for (int k = 0; k < array6.Length; k++)
					{
						array6[k].m_CharacterRole = CharacterRole.Inmate;
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
				if (GUI.Button(new Rect(100f, 330f, 180f, 30f), "[I] Infinite Durability", guistyle))
				{
					foreach (Item item9 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						Debug.Log("Font name: " + GUI.skin.button.font.name);
					}
				}
				if (GUI.Button(new Rect(100f, 360f, 180f, 30f), "Give and Assign", guistyle))
				{
					Item[] array10 = (Item[])UnityEngine.Object.FindObjectsOfTypeIncludingAssets(typeof(Item));
					foreach (Item item8 in UnityEngine.Object.FindObjectsOfType<Item>())
					{
						if (item8.m_ItemContainer == T17NetView.Find<Player>(2974).gameObject.GetComponent<ItemContainer>())
						{
							MonoBehaviour.print(item8.ItemDataID + item8.ItemName);
							if (item8.ItemDataID == 105)
							{
								foreach (ItemData itemData10 in UnityEngine.Object.FindObjectsOfType<ItemData>())
								{
									if (itemData10.name == "KeyMouldGreen_ItemData")
									{
										MonoBehaviour.print("found");
										item8.m_ItemData = itemData10;
									}
								}
							}
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
			ModMenu.Additionned = 0;
			ModMenu.SearchedPlayerWantedItemWithItemdata = false;
			ModMenu.SearchAllItemData = false;
			ModMenu.SearchedAllItem = false;
			ModMenu.Searchedallitemnameforunused = false;
			ModMenu.intItemDataIDPlayerWants = "ID eg. 254";
		}

		// Token: 0x060094F6 RID: 38134
		private static Texture2D MakeTexture(int width, int height, Color color)
		{
			Color[] pixels = new Color[width * height];
			for (int i = 0; i < pixels.Length; i++)
			{
				pixels[i] = color;
			}
			Texture2D texture2D = new Texture2D(width, height);
			texture2D.SetPixels(pixels);
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

		// Token: 0x04007119 RID: 28953
		public static string changeFloor;

		// Token: 0x040071D4 RID: 29140
		public static PhotonMessageInfo photonMessageInfo;

		// Token: 0x04007307 RID: 29447
		public static bool SearchedPlayerWantedItemWithItemdata;

		// Token: 0x0400732D RID: 29485
		public static bool SearchAllItemData;

		// Token: 0x0400734B RID: 29515
		public static bool SearchedAllItem;

		// Token: 0x04007388 RID: 29576
		public static bool Searchedallitemnameforunused;

		// Token: 0x04007671 RID: 30321
		public static string intItemDataIDPlayerWants;
	}
}
