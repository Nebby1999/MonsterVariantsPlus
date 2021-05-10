
# MonsterVariantsPlus
- An Addon for Rob's [MonsterVariants](https://thunderstore.io/package/rob/MonsterVariants/)
- Adds Custom Variants on top of Rob's Existing Variants
- Killing a Variant now Gives rewards Depending on their Tier (Common, Uncommon & Rare)
- (Note, Tiers are not mentioned in Rob's page, each Variant has a Tier assigned to it which cannot be changed via configuration.)
- Rewards include Extra gold based off a Multiplier, Extra XP based off a Multiplier, & a Chance for an item to drop from the Variant (As if the Artifact of Sacrifice was Active).
- Rewards Configurable, including the Gold Multiplier, the XP Multiplier, & the Item drop chances.

## Features

### Gold Bonus
Receive extra gold when killing a Variant, based off a Multiplier. Values Configurable, and the default values are:
	
	- 1.3 for Common Variants
	- 1.6 for Uncommon Variants
	- 2.0 for Rare Variants

### XP Bonus
Receive extra XP when killing a Variant, based off a Multiplier. Values Configurable, and the default values are:
	
	- 1.3 for Common Variants
	- 1.6 for Uncommon Variants
	- 2.0 for Rare Variants

### Item Drops
Each time you kill a Variant, there's a small chance for it to drop an Item which's tier can be White, Green or Red.
Chances are highly configurable, and each Tier has it's own chances, by default, Common tier variants can only drop white items, while a rare variant might give you a red item if you're lucky enough! (Note: not actually affected by the Luck stat)
The default values for the Item drops are right below (It is recommended to check out the "Configuring the Mod" section for an explanation of how the Item drop mechanic works.
	
	Common Variants:
	- 3% for a White item
	- 0% for a Green item
	- 0% for a Red item
	
	Uncommon Variants:
	- 5% for a White item
	- 1% for a Green item
	- 0% for a Red Item
	
	Rare Variants:
	- 10% for a White Item
	- 5% for a Green Item
	- 1% for a Red Item
In the case the variant is fought inside a hidden realm, a special config entry exists to determine how the mod calculates the chances for an item drop. these settings are used so players dont spend time in hidden realms farming for items.
The Settings are:
Unchanged: No changes are made, numbers above stay the same.
Halved: When the variant dies, there's a 50% Chance the mod will roll the dice to determine wether or not an item spawns.
Never: Variants never drop items in hidden realms.

### New Variants
Steel Contraption
![](https://cdn.discordapp.com/attachments/570060692414267397/834156504697274430/SteelContraption.png)
AD-Shroom
![](https://cdn.discordapp.com/attachments/570060692414267397/834156508047736882/ADShroom.png)
Version 1.2.0 introduces new Variants to the game designed by Nebby.
The end goal is to have at least one variant per type of enemy.
Just Like in the Original Monster Variants, their spawn chance can be changed in the config file.
If you don't want any new variants, you can also disable the entire section in the config file.

Since Version 1.3.7 of MonsterVariants, Modded variants are now possible to create. Currently it only supports Moffein's ClayMen & AncientWisp
Since Version 1.3.9 of MonsterVariants, Modded Variant's now have custom names to showcase their abilities.

	Leastest Wisp (Lesser Wisp)(7% Chance):
	- 50% Size
	- 50% Health
	- 500% Movement Speed
	- 500% Attack Speed
	- 110% Damage
	- Has 5 Alien Heads
	
	Almost-But-Not-Quite-Archaic Wisp (Lesser Wisp)(4% Chance)
	- 125% Size
	- 500% Health
	- Fires Archaic Wisp Fireballs

	Steel Contraption (Brass Contraption)(7% Chance):
	- 100% Size
	- 150% Health
	- 50% Movement Speed
	- 75% Attack Speed
	- 150% Damage
	
	Aluminum Contraption (Brass Contraption)(7% Chance):
	- 50% Size
	- 50% Health
	- 200% Movement Speed
	- 200% Attack Speed
	- 50% Damage
	- Has 1 Alien Head
	
	Mortar Crab (Hermit Crab)(5% Chance):
	- 150% Size
	- 150% Health
	- 80% Movement Speed
	- 80% Attack Speed
	- Has a Brilliant Behemoth

	Vampiric Templar (Clay Templar)(5% Chance):
	- 125% Size
	- 125% Attack Speed
	- 150% Health
	- 50% Damage
	- Has 10 Lensmarker Glasses
	- Has 20 Harvester Scythes

	AD-Shroom (MiniMushroom)(6% Chance):
	- 75% Size
	- 1000% Attack Speed
	- 6.2% Damage
	- Has 10 Alien Heads

	Healer-Shroom (MiniMushroom)(10% Chance):
	- 50% Size
	- 200% Movement Speed
	- 25% Attack Speed
	- 50% Damage
	- Has 5 Bustling Fungus

	Mama-Shroom (MiniMushroom) (2% Chance): (Based off an idea by Awesome_Soul)
	- 200% Size
	- 200% HP
	- 0% Movement Speed
	- -50 Armor
	- Has 10 Bustling Fungus
	- Has 1 Aegis

	Adolescent (Parent)(8% Chance): (Based off an idea by Zarko)
	- 75% Size
	- 75% Health
	- 120% Attack Speed
	- Has 1 Medkit
	- Has 1 Planula
	- Has 1 Hardlight Afterburner
	- Has 3 Alien Heads

	Child (Parent)(6% Chance): (Based off an idea by Ululu)
	- 50% Size
	- 300% Movement Speed
	- 600% Attack Speed
	- 50% Damage
	- Has 1 Alien Head
	- Cannot Teleport

	Bruiser Imp (Imp)(10% Chance):
	- 125% Size
	- 300% Movement Speed
	- 200% Attack Speed
	- Has 5 Alien Heads
	- Has 3 Crowbars
	- Cannot Teleport

	Alpha Bison (Bighorn Bison)(5% Chance): (Based off an idea by Gaforb)
	- 125% Size
	- 75% Health
	- 200% Movement Speed
	- 200% Attack Speed
	- 70% Damage
	- Has 2 Brilliant Behemoths

	Wisp Amalgamate (Greater Wisp)(8% Chance)
	- 75% Size
	- Attacks with a hitscan attack, much like the regular wisp
	- Spawns 5 Wisps upon Death

	Kinda-Great-But-Not-Greater Wisp (Greater Wisp)(6% Chance)
	- 50% Size
	- 50% Health
	- 500% Movement Speed
	- 250% Attack Speed
	- Has 2 Alien Heads

	Swarmer Probe (Solus Probe)(7% Chance)
	- 50% Size
	- 50% Health
	- 400% Movement Speed
	- 400% Attack Speed
	- 30% Damage

	Incinerating Elder Lemurian (Elder Lemurian)(5% Chance)
	- 125% Size
	- 200% Movement Speed
	- 3000% Attack Speed
	- 750% Damage
	- -50 Armor
	- Has 5 Brilliant Behemoths
	- Cannot shoot fireball volley, limiting his arsenal to just it's close-range flame thrower.

	Sun Priest (GrandParent)(3% Chance): (Based off an idea by Ululu)
	- Can use Solar Flare at any point in time.
	- -50 Armor

	Hoarder (Scavenger)(8% Chance): (Based off an idea by Gaforb)
	- 75% Size
	- 75% Health
	- 125% Movement Speed
	- 125% Attack Speed
	- 90% Damage
	- Its skill to obtain an item from his backpack has a cooldown of 10 seconds instead of the usual 20.

	Starving Dunestrider (Clay Dunestrider)(4% Chance):
	- Can use Life Draining Tendrils at any point in time.
	- Has a Hardlight Afterburner
	- -50 Armor

	Devourer Dunestrider (Clay Dunestrider)(2% Chance): (Mildly based off an idea by Gaforb)
	- 125% Size
	- 120% Movement Speed
	- 110% Attack Speed
	- Has 2 Rejuvination Racks
	- Has 2 Aegis
	- Life Draining Tendrils has a 90 Second Cooldown, Lasts Twice as Long, the Tethers are Twice as Long, and the Dunestrider no longer gains Armor.

	Malfunctioning Solus Control Unit (Solus Control Unit)(4% Chance):
	- Can use Solus Charged Detonation at any point in time.
	- -50 Armor

	Malfunctioning Alloy Worship Unit (Alloy Worship Unit)(4% Chance):
	- Can use Alloy Supercharged Detonation at any point in time.
	- -50 Armor

	Ancient Stone Titan (Stone Titan)(4% Chance):
	- Can use Eye Laser & Stone Construct at any point in time.
	- -50 Armor

	Ancient Aurelionite (Aurelionite)(4% Chance):
	- Can use Eye Laser & Stone Construct at Any Point in Time

	Aurelionite Colosus (Aurelionite)(2% Chance):
	- 300% Size
	- 50% Movement Speed
	- 200% Damage
	- 50 Armor
	- Has 3 Alien Heads

	Pygmy Aurelionite (Aurelionite)(2% Chance):
	- 30% Size
	- 500% Movement Speed

	Beetle Matriarch (Beetle Queen)(4% Chance):
	- The Beetle Summon Ability summons both Beetle Guards as well as Normal Beetles
	- -50 Armor

	Beetle Empress (Beetle Queen)(2% Chance):
	- 125% Size
	- 120% Health
	- Has 2 Queens Gland
	- -70 Armor
	
	Clay Soldier (ClayMen)(Requires Moffeins ClayMen)(15% Chance):
	- 112.5% Size
	- 125% Health
	- 90% Movement Speed
	- 150% Attack Speed
	- 50% Damage
	- Has 1 Alien Head

	Clay Assasin (ClayMen)(Requires Moffeins ClayMen)(7% Spawn Chance):
	- 75% Size
	- 120% Movement Speed
	- Has 3 Tritip Daggers
	- Has 1 Old War Stealthkit
	- -25 Armor

	Enraged Wisp (Ancient Wisp)(Requires Moffeins Ancient Wisp)(4% Chance)
	-Can use its enrage ability at any point in time
	- -50 Armor
	
	Amalgamated Ancient Wisp (Ancient Wisp)(Requires Moffeins Ancient Wisp)(2% Chance)
	- 125% Size
	- 120% Movement Speed
	- 110% Attack Speed
	- -50 Armor
	- Spawns 5 Greater Wisps upon Death

	Aeonic Wisp (Archaic Wisp)(Requires Nebbys Archaic Wisp)(4% Chance)
	- 125% Size
	- 200% Health
	- 90% Movement Speed
	- 90% Attack Speed
	- 20 Armor
	- Has 1 Brilliant Behemoth

	Kinda-Archaic Wisp (Archaic Wisp)(Requires Nebbys Archaic Wisp)(7% Chance)
	- 50% Size
	- 50% Health
	- 500% Movement Speed
	- 250% Attack Speed
	- Has 2 Alien Heads

## Other Variants
A new adition from update 1.3.0, Other variants include a list of potentially helpful Creature variants.
Currently only adds variants for 2 Creatures, the Beetleguards from the Queen's Gland item (Taken directly from Rob's Original mod) & the Squid Turrets from the Squid Polyp
All of these variants can be toggled OFF with a simple boolean switch, found at the top of the "5 - Other Variants" Category in the Config File.
If you wish to disable specific variants, just like regular variants, their spawn chances can be set to 0 to disable them from spawning.
While these might sound like they'll give you the advantage in combat, keep in mind that these variants are not Team dependant, so enemies like KipKip the Gentle can spawn with Beetle Guard Variants!

	Beetle Guard Brute - QueensGland (Beetle Guard)(25% chance)
	- 110% Size
	- 200% Health
	- 50% Movement speed
	- 90% Attack speed
	- 140% Damage
	- +10 Armor
	
	Beetle Guard Sharpshooter - QueensGland (Beetle Guard)(2% chance)
	- 80% Size
	- 80% Health
	- 60% Movement speed
	- 300% Attack speed
	- 40% Damage
	- Has 10 Alien Heads

	Sniper Squid (Squid Turret)(2% Chance)
	- 125% Size
	- 10% Attack Speed
	- 1000% Damage
	- -100 Armor

	Chaingun Squid (Squid Turret)(10% Chance)
	- 50% Size
	- 500% Attack Speed
	- 30% Damage

## Configuring the Mod.
This section is for explaining how the Item drop chance mechanic works, since it's not based off the normal % chance ROR2 has.
- The Chance is determined via first rolling a D100, the result of this roll is a Float (a number with decimals).
- It then begins checking if the result from the D100 is LOWER than the reward, in the example below, if the D100 rolled a 1 or lower, then the monster will drop a Red item.
- It First checks for the Red chance, then the Green Chance and then the White chance, so, for example, if the D100 rolled a number that's greater than 6 but less than 10, then it will only drop a white item.
![](https://cdn.discordapp.com/attachments/570060692414267397/824472489152741386/thingy.png)

## Installation
To install the addon, simply drag the MonsterVariantsPlus.dll onto your plugins folder. Make sure Rob's DLL is also there, or else the plugin will not activate.

## Future Plans
- Have Boss variants drop their Boss item based off Chance.
- Create actually pleasing to the eyes textures for the variants instead of the awful look of some of them *cough cough* Alpha Bison *cough cough*
- Wait for Rob to implement DeathState replacers to replace the Wisp Amalgamate's death behavior instead of using a hook, which would increase performance overall.
- Make some wizardry to improve the Wisp Amalgamate's Death explosion & it's light emmiting properties so they arent green.

## Contacting
In case you need to contact me regarding a Bug, please create an issue in the Github's Issue Tracker found [Here](https://github.com/Nebby1999/MonsterVariantsPlus/issues)
I also hang out in the Official [Risk of Rain 2 Modding](https://discord.gg/5MbXZvd) Discord server under the name of "Nebby" in case you want to contact me for other purposes, such as suggestions or feedback. I Always appreciate any kind of feedback.

## Special Thanks
Rob, for making his MonsterVariants mod and helping me a lot with questions i've had
KomradeSpectre, for helping me a ton with making the variants have custom skins.

## Changelog
'1.3.6' Nebby did a poopy update
	- Beetle Matriarchs default spawn rate is now 4 as its noted, instead of 100.

'1.3.5' Beetle Update
- Added two new Beetle Queen variants
	- Beetle Matriarch
	- Beetle Empress
- Changes to the following variants
	- Clay Assasin
		-- 3 Tritip Daggers -> 5 Tritip Daggers
		-- 120% Movement Speed -> 125% Movement Speed
		-- Now properly uses a ghost material instead of being invulnerable.
	- Clay Soldier
		-- 50% Damage -> 60% Damage
- Added Missing Variants to the Config Checker.

'1.3.3' Whoops i accidentally made an invincible enemy uvu
- Fixed the clay assasins being invulnerable.

'1.3.2' Hidden Realms Nerf update.
- Added a new config entry that dictates how the Item Drop behavior works on Hidden Realms.
- Fixed M.O.A.J. not spawning jellyfishes on death.
- Tweaked the Following Variants:
	- Almost-But-Not-Quite-Archaic Wisp.
		-- 600 HP -> 500% HP
	- AD-Shroom
		-- 500% Attack Speed -> 1000% Attack Speed
		-- 5 Alien Heads -> 10 Alien Heads
	- Healer Shroom
		-- 50% Attack Speed -> 25% Attack Speed
		-- 2 Bustling Fungus -> 5 Bustling Fungus.
	- Mama Shroom
		-- 100% HP -> 200% HP
	- Bruiser Imp
		-- 80% HP -> 100% HP
		-- 200% Movement Speed -> 300% Movement Speed
		-- 2 Crowbars -> 3 Crowbars
	- Kinda Great But Not Greater Wisp
		-- 500% Attack Speed -> 250% Attack Speed
	- Incinerating Elder Lemurian
		-- 150% Movement Speed -> 300% Movement Speed
	- Starving Dunestrider
		-- Added a Hardlight Afterburner
	- Kinda Archaic Wisp
		-- 500% Attack Speed -> 250% Attack Speed.
- Added the Following Variants:
	- Clay Assasin
	- Ancient Stone Titan
	- Ancient Aurelionite
	- Aurelionite Colosus
	- Pygmy Aurelionite

'1.3.1' Whoops, More Variants!
- Added a failsafe mechanism that runs every time the mod loads, it checks if the values on the config file are invalid (Can be disabled).
- Added the Following Variants:
	- Almost-But-Not-Quite-Archaic Wisp.
	- Mama Shroom.
	- Kinda-Great-But-Not-Greater Wisp.
	- Swarmer Probe.
	- Incinerating Elder Lemurian.
	- Amalgamated Ancient Wisp.
	- Aeonic Wisp.
	- Kinda-Archaic Wisp.
- Changed how certain enemies spawn enemies on death.
- Wisp Amalgamate now spawns 5 lesser wisps on death.
- Rob's M.O.A.J now spawns 5 jellyfishes on death.
- Added proper credits to the people who suggested variants.

'1.3.0' Code Cleanup & Other Variants Update
- Refractored how the config file is generated, it's EXTREMELY advised that you delete your existing config file so the new one generates without any errors!
- Added the Malfunctioning Solus Control Unit
- Added the Malfunctioning Alloy Worship Unit,
- Added Other Variants. Variants that not necesarily belong to the Enemy Team.
- Added the Beetle Guard Brute - Gland
- Added the Beetle Guard Sharpshooter - Gland
- Added the Sniper Squid
- Added the Chaingun Squid.

'1.2.9' Wispception update
- Added the Wisp Amalgamate
- Added the Aluminum Contraption
- Added the Enraged Wisp

'1.2.8'
- Nerfed the Adolescent, no longer has nkhunna's opinion
	-- 10% Health -> 75% Health
	-- Changed it's inventory to now have 1 Medkit and 1 Planula instead of nkhunna's opinion.
- The Devourer Dunestrider now properly has it's inventory, which adds 2 Aegis alongside the 2 Rejuvination Racks.
- Added Healershroom
- Added Sun Worshipper
- Added Starving Dunestrider
- Added nameOverride strings so Variants now are properly named in-game
- A bunch of internal code changes.

'1.2.7' Whoops, All Variants! Update
- Added Adolescent, Child, Bruiser Imp, Alpha Bison, Hoarder, Devourer Dunestrider & Clay Soldier Variants.
- Probably forgot about something, feedback is greatly appreciated when confronting these new monsters.

'1.2.6' Public Methods baybeeee Update
- Updated MonsterVariants Dependency to version 1.3.7
- Removed a lot of now unecesary methods since Rob made a lot of his methods public instead of internal (Thanks rob, very cool <3)

'1.2.5' Variant Identification Update
- A Lot of internal changes, too many to write down, lol.
- Nerfed the Mortar Crab, shouldnt one-shot players now (i hope)
	-- 125% Damage -> 100% Damage
- Added AD-Shroom Variant
- Added Unique skins for custom variants.
- Added a new Skin for Steel Contraption
- Added a new Skin for AD-Shroom Variant

'1.2.4' Variant Rebalance Update
- Changed the Leastest Wisp.
	-- Common Tier -> Uncommon	Tier
	-- 30% Spawn Chance -> 7% Spawn Chance
	-- 1000% Attack Speed -> 500% Attack Speed
	-- Now Spawns with 5 Alien Heads, causing it's Attack cooldown to be 1 second instead of 4.
- Changed the Steel Contraption.
	-- 150% Size -> 100% Size
	-- 150% Health -> 175% Health
	-- 50% Attack Speed -> 75% Attack Speed
	-- Removal of Size was because it caused problems with the Contraption's Aiming, Expect another easy way to differentiate them in the future.
- Changed the Vampiric Templar
	-- 90% Damage -> 50% Damage
	-- Replaced 5 Tri-Tip Daggers with 10 Lensmarker Glasses (Effective Damage is the same as a regular Templar.)
	-- Replaced 10 Leeching Seeds with 20 Harvester Scythes (4.4HP+ per hit)

'1.2.3'
- Now Ships with this version instead of 1.2.1.
- Added a missing Semi-Colon in Config Loader that caused the mod to not compile, whoops.

'1.2.2' Vampiric Templar Update
- Increased the spawn chance of a Leastest Wisp to 30%
-  Added Vampiric Templar Variant
-  Slightly Buffed Leastest Wisps, so theyre more annoying (as a mosquito should be)
	-- 200% Movement Speed -> 500% Movement Speed
	-- 200% Attack Speed -> 1000% Attack Speed
	-- 100% Damage -> 110% Damage

'1.2.1'
- Added spawn chances to the Readme file.

'1.2.0' Custom Variants Update
- Added 3 New Variants.
- Steel Contraption.
- Leastest Wisp.
- Mortar Crab.

'1.1.1'
- Added an option for item rewards to spawn based off the player who killed the variant.

'1.1.0' Anniversary Update
- Updated for the Anniversary Update.
- Added the XP Multiplier System.

'1.0.5'
- Added the Github Repository.
- Hopefully fixed a Small formatting error in the readme.md file.

'1.0.4'
- I swear to god if this doesnt fix the error i'll kms.

'1.0.3'
-Actually ACTUALLY fixed the Error.

'1.0.2'
- Actually fixed the damn error.

'1.0.1'
- Fixed formatting error inside the README.md file.

'1.0.0'
- Initial Release.