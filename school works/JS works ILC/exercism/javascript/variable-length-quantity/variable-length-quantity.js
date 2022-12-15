export const encode = (hexNum) => { 
  let sn = [];

  hexNum.map(num => sn = sn.concat(hexToBase128(num)))

  return base128InHex(sn)
};

export const base128InHex = (number) => { 
  return number.map( bitNumber => parseInt(bitNumber, 2))
}

export const hexToBase128 = (number) => {
  if (number === 0 ) { return [0] };

  number  = parseInt(number).toString(2);

  let groupedBitsFromNumber = [];
  let bitsLeftWithoutGroup = number.length % 7;

  if (bitsLeftWithoutGroup !== 0) {
    groupedBitsFromNumber = ["1" + "0".repeat(7-bitsLeftWithoutGroup) + number.slice(0, bitsLeftWithoutGroup)];
  }

  for (let bitPosition = bitsLeftWithoutGroup; bitPosition < number.length; bitPosition+=7) { 
    let msb = 1;
    if (bitPosition === number.length-7) { msb = 0 }; 
    groupedBitsFromNumber.push( msb + number.slice(bitPosition, bitPosition+7));
  }

  return groupedBitsFromNumber;
}

export const decode = (number) => {

  number  = number.map( numberAux => parseInt(numberAux).toString(2));
  if (number[number.length-1].length === 8 ) {
    throw new Error('Incomplete sequence')
  }
  number = number.map( numberAux => {
    if (numberAux === "0") {
      return "0000000";
    } else if (numberAux.length === 8) {
        return numberAux.slice(1)
      } else {
        return numberAux;
      }
    });

  number = number.reduce( (acc, curr) => acc + curr)

  number = parseInt(number,2);

  return [number]
};