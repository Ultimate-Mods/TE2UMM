# The Escapists 2 Ultimate Mod Menu

Mod menu created modifying Assembly-CSharp.dll using DNSpy.

This mod menu **should only** be used in single-player.

This DLL is completly safe, you can grab the source code using DNSpy.

This mod menu only works in Local/SinglePlayer or **only** if you are the Host.

# TO DO LIST

- [x] Player & Prison Cheats
- [ ] ~~Multiplayer Cheats~~
- [x] Level Editor Cheats/Utility
- [x] Better UI Design
- [x] Give item with text box (No spaces)
- [ ] Free craft
- [x] Change floor cheat
- [ ] Destroy environment cheat (eg the wall in front of you)
- [x] Load any prisons (even DLCs u dont own)

# Features

## Player Cheat

• Max Player Stats

• Noclip (Toggleable)

• Speed Hack (Toggleable)

• Open Every Doors (makes every doors open)

• Unlock every doors (be able to open them)

• Give specificated items (Text field) (REVAMPED, it freezes and glitchy but technically better (down for more infos))

• Change floor

• "Load" any playable prisons (down for more infos)

## Prison Cheats

• Lockdown (Toggleable)

• Toggle Electirc Fences (Toggleable)

• Make all NPCs hittable

• Disable dogs

## Level Editor 

• Bypass every zone requirements (Minimum & Maximum objects in zones)

• Bypass Zone Validation (useless if using bypass requirements)

![](https://media.discordapp.net/attachments/1123000484437958697/1131781481782591580/image.png)

## The Give system

Before, to give an item, I was just checking all items instances that already exists, pick the one the player wanted, then moved it to the player.

Now, I use "Unused" items from the instances (they are empty items and there are like 400 of them), then put the ItemDataID of the item the player wants, then move the unused item to the player inventory.

This is buggy and unstable, you should not use it.

## The Prison overwrite system

You will have a menu with every prisons, click which one you want, then it will overwrite Center Perks 2.0 to the prison you clicked.

Saving and loading works. No issues found
