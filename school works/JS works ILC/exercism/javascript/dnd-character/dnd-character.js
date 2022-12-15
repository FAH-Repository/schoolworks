const roll = (numberOfDice = 4, numberOfSides = 6) =>
  Array(numberOfDice)
    .fill(0)
    // eslint-disable-next-line no-unused-vars
    .map((_) => Math.floor(Math.random() * numberOfSides) + 1);
const diceReducer = (sum, die) => sum + die;
const diceSum = (dice) =>
  [...dice]
    .sort((a, b) => b - a)
    .slice(0, dice.length - 1)
    .reduce(diceReducer, 0);

export const abilityModifier = (constitution) => {
  if (constitution < 3) {
    throw new Error('Ability scores must be at least 3');
  } else if (constitution > 18) {
    throw new Error('Ability scores can be at most 18');
  } else {
    return Math.floor((constitution - 10) / 2);
  }
};

export class Character {
  constructor() {
    this._strength = roll();
    this._dexterity = roll();
    this._constitution = roll();
    this._intelligence = roll();
    this._wisdom = roll();
    this._charima = roll();
  }

  static rollAbility(
    optionalDiceSet = null,
    numberOfDice = 4,
    numberOfSides = 6
  ) {
    return optionalDiceSet
      ? diceSum(optionalDiceSet)
      : diceSum(roll(numberOfDice, numberOfSides));
  }

  get strength() {
    return(diceSum(this._strength));
  }

  get dexterity() {
    return(diceSum(this._dexterity));
  }

  get constitution() {
    return(diceSum(this._constitution));
  }

  get intelligence() {
    return(diceSum(this._intelligence));
  }

  get wisdom() {
    return(diceSum(this._wisdom));
  }

  get charisma() {
    return(diceSum(this._charima));
  }

  get hitpoints() {
    return abilityModifier(this.constitution) + 10;
  }
}