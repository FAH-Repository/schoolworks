export const square = (num) => {
  try {
    validate(num);
    return BigInt(2 ** (num - 1));
  } catch (ex) {
    throw ex;
  }

};

export const total = () => {
  let accum = BigInt(0);

  for(let i = 1; i <= 64; i++) accum += square(i);

  return accum;
};

const validate = (num) => {
  if(num <= 0 || num > 64) throw new Error('square must be between 1 and 64');
};