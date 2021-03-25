## MonsterVariants+
- An Addon for Rob's [MonsterVariants](https://thunderstore.io/package/rob/MonsterVariants/)
- Killing a Variant now Gives rewards Depending on their Tier (Common, Uncommon & Rare)
- (Note, Tiers are not mentioned in Rob's page, each Variant has a Tier assigned to it which cannot be changed via configuration.)
- Rewards include Extra gold based off a Multiplier & a Chance for an item to drop from the Variant (As if the Artifact of Sacrifice was Active)
- Rewards Mildly Configurable, including the Gold Multiplier and the Item drop chances.

##Features

#Gold Bonus
Recieve extra gold when killing a Variant, based off a Multiplier. Values Configurable, and the default values are:
- 1.3 for Common Variants
- 1.6 for Uncommon Variants
- 2.0 for Rare Variants

#Item Drops
Each time you kill a Variant, there's a small chance for it to drop an Item which's tier can be White, Green or Red.
Chances are highly configurable, and each Tier has it's own chances, by default, Common tier variants can only drop white items, while a rare variant might give you a red item if youre lucky enough! (Note: not actually affected by the Luck stat)
The default values for the Item drops are right below (It is reccomended to check out the "Configuring the Mod" section for an explanation of how the Item drop mechanic works.
	
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

##Configuring the Mod.
This section is for explaining how the Item drop chance mechanic works, since it's not based off the normal % chance ROR2 has.
- The Chance is determined via first rolling a D100, the result of this roll is a Float (a number with decimals).
- It then begins checking if the result from the D100 is LOWER than the reward, in the example below, if the D100 rolled a 1 or lower, then the monster will drop a Red item.
- It First checks for the Red chance, then the Green Chance and then the White chance, so, for example, if the D100 rolled a number that's greater than 6 but less than 10, then it will only drop a white item.
![](https://cdn.discordapp.com/attachments/570060692414267397/824472489152741386/thingy.png)

##Installation
To install the addon, simply drag the MonsterVariantsPlus.dll onto your plugins folder. Make sure Rob's DLL is also there, or else the plugin will not activate.

## Future Plans
- Make the player obtain extra experience for killing a Variant
- Add new variants on top of rob's existing ones
- Have Boss variants drop their Boss item based off Chance.

##Changelog
'1.0.5'
- Added the Github Repository
- Hopefully fixed a Small formatting error in the readme.md file

'1.0.4'
- I swear to god if this doesnt fix the error i'll kms

'1.0.3'
-Actually ACTUALLY fixed the Error.

'1.0.2'
- Actually fixed the damn error.

'1.0.1'
- Fixed formatting error inside the README.md file.

'1.0.0'
- Initial Release.