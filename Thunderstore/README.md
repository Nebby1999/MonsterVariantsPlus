

# MonsterVariantsPlus
- An Addon for Rob's [MonsterVariants](https://thunderstore.io/package/rob/MonsterVariants/)
- Adds Custom Variants on top of Rob's Existing Variants
- Killing a Variant now Gives rewards Depending on their Tier (Common, Uncommon & Rare)
- (Note, Tiers are not mentioned in Rob's page, each Variant has a Tier assigned to it which cannot be changed via configuration.)
- Rewards include Extra gold based off a Multiplier, Extra XP based off a Multiplier, & a Chance for an item to drop from the Variant (As if the Artifact of Sacrifice was Active).
- Rewards Configurable, including the Gold Multiplier, the XP Multiplier, & the Item drop chances.

## Features

### Gold Bonus
Receive extra gold when killing a Variant, based off a Multiplier & the Variant's Tier. Values are fully Configurable.
Default Values:

	- 1.3 for Common Variants
	- 1.6 for Uncommon Variants
	- 2.0 for Rare Variants
For more information regarding the Gold Bonus, such as how it works and it's default values, check out it's wiki page. [Link](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Gold-Reward-System)

### XP Bonus
Receive extra XP when killing a Variant, based off a Multiplier & the Variant's Tier. Values are fully Configurable.
Default Values:
	
	- 1.3 for Common Variants
	- 1.6 for Uncommon Variants
	- 2.0 for Rare Variants
For more information regarding the Gold Bonus, such as how it works and it's default values, check out it's wiki page. [Link](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/XP-Reward-System)

## Item Drops
Each time you kill a Variant, there's a small chance for it to drop an Item which's tier can be White, Green or Red.
Chances are highly configurable, and each Tier has it's own chances. (drop chances are not affected by the Luck stat).
Default Values:
	
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

To avoid the player farming items inside hidden realms, a special config entry exists to determine how the mod calculates the chances for an item drop.
The Settings are:
Unchanged: No changes are made.
Halved: When the variant dies, there's a 50% Chance the mod will roll the dice to determine wether or not an item spawns.
Never: Variants never drop items in hidden realms.

It is highly recommended that you check out it's Wiki page, since there you can find a better explanation of how the item drop mechanic works. [Link](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Item-Reward-System)

### New Variants
Steel Contraption
![](https://cdn.discordapp.com/attachments/570060692414267397/834156504697274430/SteelContraption.png)
AD-Shroom
![](https://cdn.discordapp.com/attachments/570060692414267397/834156508047736882/ADShroom.png)
Version 1.2.0 introduces new Variants to the game designed by Nebby.
The end goal is to have at least one variant per type of enemy.
Just Like in the Original Monster Variants, their spawn chance can be changed in the config file.
All of my variants have custom names, so if you find a new one, you can ping it and it's name will show up.
If you don't want any new variants, you can also disable the entire section in the config file.
Due to the increasing list of variants, from now on only their Names and it's spawn chances will apear in the list below, you can check out the MonsterVariantsPlus wiki for all the details regarding the new Variants. [Link](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Enemy-Variants#enemy-list)
Or you can click a variant's name and a new browser tab will open up with it's wiki entry.

> 
> - [Leastest Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Lesser-Wisp-Variants#leastest-wisp)
> - 7% Chance	
> - [Almost-But-Not-Quite-Archaic Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Lesser-Wisp-Variants#almost-but-not-quite-archaic-wisp)
> - 4% Chance
> - [Steel Contraption](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Brass-Contraption-Variants#steel-contraption)
> - 7% Chance
> - [Aluminum Contraption](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Brass-Contraption-Variants#aluminum-contraption)
> - 7% Chance
> - [Mortar Crab](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Hermit-Crab-Variants#mortar-crab)
> - 5% Chance
> - [Vampiric Templar](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Clay-Templar-Variants#vampiric-templar)
> - 5% Chance
> - [AD-Shroom](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Mini-Mushrum-Variants#ad-shroom)
> - 6% Chance
> - [Healer-Shroom](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Mini-Mushrum-Variants#healer-shroom)
> - 10% Chance
> - [Mama-Shroom](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Mini-Mushrum-Variants#mama-shroom)
> - 2% Chance
> - [Adolescent](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Parent-Variants#adolescent)
> - 8% Chance
> - [Child](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Parent-Variants#child)
> - 6% Chance
> - [Bruiser Imp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Parent-Variants#child)
> - 10% Chance
> - [Alpha Bison](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Bighorn-Bison-Variants#alpha-bison)
> - 5% Chance
> - [Wisp Amalgamate](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Greater-Wisp-Variants#wisp-amalgamate)
> - 8% Chance
> - [Kinda-Great-But-Not-Greater Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Greater-Wisp-Variants#kinda-great-but-not-greater-wisp)
> - 6% Chance
> - [Swarmer Probe](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Solus-Probe-Variants#swarmer-probe)
> - 7% Chance
> - [Incinerating Elder Lemurian](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Elder-Lemurian-Variants#incinerating-elder-lemurian)
> - 5% Chance
> - [Sun Priest](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Grandparent-Variants#sun-priest)
> - 4% Chance
> - [Hoarder](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Scavenger-Variants#hoarder)
> - 8% Chance
> - [Starving Dunestrider](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Clay-Dunestrider-Variants#starving-dunestrider)
> - 4% Chance
> - [Devourer Dunestrider](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Clay-Dunestrider-Variants#devourer-dunestrider)
> - 2% Chance
> - [Malfunctioning Solus Control Unit](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Solus-Control-Unit-Variants#malfunctioning-solus-control-unit)
> - 4% Chance
> - [Malfunctioning Alloy Worship Unit](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Alloy-Worship-Unit-Variants)
> - 4% Chance
> - [Ancient Stone Titan](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Stone-Titan-Variants#ancient-stone-titan)
> - 4% Chance
> - [Ancient Aurelionite](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Aurelionite-Variants#ancient-aurelionite)
> - 4% Chance
> - [Aurelionite Colosus](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Aurelionite-Variants#aurelionite-colosus)
> - 2% Chance
> - [Pygmy Aurelionite](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Aurelionite-Variants#pygmy-aurelionite)
> - 2% Chance
> - [Beetle Matriarch](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Beetle-Queen-Variants#beetle-matriarch)
> - 4% Chance
> - [Beetle Empress](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Beetle-Queen-Variants#beetle-empress)
> - 2% Chance

### Modded Variants
Monster Variants Plus also adds variants for modded enemies, given if their mod is installed.
All the things said in the "New Variants" section also applies to these variants
> - [Clay Soldier](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Clay-Man-Variants#clay-soldier)[(Mod Link)](https://thunderstore.io/package/Moffein/Clay_Men/)
> - 15% Chance
> - [Clay Assasin](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Clay-Man-Variants#clay-assasin)[(Mod Link)](https://thunderstore.io/package/Moffein/Clay_Men/)
> - 7% Chance
> - [Enraged Ancient Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Ancient-Wisp-Variants#enraged-wisp)[(Mod Link)](https://thunderstore.io/package/Moffein/Ancient_Wisp/)
> - 4% Chance
> - [Amalgamated Ancient Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Ancient-Wisp-Variants#amalgamated-ancient-wisp)[(Mod Link)](https://thunderstore.io/package/Moffein/Ancient_Wisp/)
> - 2% Chance
> - [Aeonic Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Archaic-Wisp-Variants#aeonic-wisp)[(Mod Link)](https://thunderstore.io/package/Nebby/ArchaicWisps/)
> - 4% Chance
> - [Kinda-Archaic Wisp](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Archaic-Wisp-Variants#kinda-archaic-wisp)[(Mod Link)](https://thunderstore.io/package/Nebby/ArchaicWisps/)
> - 7% Chance

## Other Variants
Other variants is a new concept, where Nebby adds variants for potentially helpful Creatres.
Other Variants can be toggled OFF with a simple boolean switch on the config file.

> - [Beetle Guard Brute - Queen's Gland](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Queen's-Gland-Beetle-Guard-Variants#beetle-guard-brute)
> - 25% Chance
> - Taken directly from Rob's Monster Variants.
> - [Beetle Guard Sharpshooter - Queen's Gland](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Queen's-Gland-Beetle-Guard-Variants#beetle-guard-sharpshooter)
> - 2% Chance
> - Taken directly from Rob's Monster Variants.
> - [Chaingun Squid](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Squid-Turret-Variants#chaingun-squid)
> - 10% Chance
> - [Sniper Squid](https://github.com/Nebby1999/MonsterVariantsPlus/wiki/Squid-Turret-Variants#sniper-squid)
> - 2% Chance

## Installation
To install the addon, simply drag the MonsterVariantsPlus.dll onto your plugins folder. Make sure Rob's DLL is also there, or else the plugin will not activate.

## Future Plans
- Have Boss variants drop their Boss item based off Chance.
- Create actually pleasing to the eyes textures for the variants instead of the awful look of some of them *cough cough* Alpha Bison *cough cough*
- Wait for Rob to implement DeathState replacers to replace the Wisp Amalgamate's death behavior instead of using a hook, which would increase performance overall.
- Make some wizardry to improve the Wisp Amalgamate's Death explosion & it's light emmiting properties so they arent green.

## Contacting
In case you need to report a bug, please do so using Github's Issue Tracker found [Here](https://github.com/Nebby1999/MonsterVariantsPlus/issues)
In case you have a suggestion for a variant, please suggest it in the Github's issue tracker using the correct label. I am no longer taking variant suggestions via discord.
I also hang out in the Official [Risk of Rain 2 Modding](https://discord.gg/5MbXZvd) Discord Server under the name of "Nebby" in case you want to contact me for other purposes.

## Special Thanks
Rob, for making his MonsterVariants mod and helping me a lot with questions i've had
KomradeSpectre, for helping me a ton with making the variants have custom skins.

## Changelog
'1.3.7' Github Update
- Created the Github Wiki, where you can check with more detail how the system of the mod works, and the full description and values of each variant (alongside some tips by me on how to defeat them)
- Due to the wiki, i've cut down the size of this ReadMe file.
- Changes to the Following Variants
	* Beetle Empress
		- Changed it's utility skill so it can only spawn regular beetles
	* Aluminum Contraption
		- 50% Damage -> 75% Damage
	* Adolescent
		- 100% Damage -> 150% Damage
	* Vampiric Templar
		- Added a Rejuvination Rack
	* Child
		- 50% Damage -> 100% Damage
	* Alpha Bison
		- 70% Damage -> 100% Damage
	* Incinerating Elder Lemurian
		- -50 Armor -> -10 Armor
		- Added a new primary, which consists of firing one mega fireball 5 times, effectively working like a burst
	* Devourer Dunestrider
		- Added 7 Focus Crystals
	* Clay Soldier
		- 60% Damage -> 75% Damage
	* Clay Assasin
		- 125% Movement Speed -> 120% Movement Speed
		- 100% Damage -> 50% Damage
		- Removed Tritip Daggers
		- Added 10 Lensmarker Glasses
		- Added a Shaterspleen
	* Aeonic Wisp
		- 200% Health -> 150% Health
		- 90% Movement Speed -> 75% Movement Speed

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