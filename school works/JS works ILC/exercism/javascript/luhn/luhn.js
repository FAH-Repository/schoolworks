export const valid = (num) => {
  num = num.replace(/ /g, '');
  if (isNaN(num) || num.length < 2) return false;

  num = [...num];
  let start = num.length % 2 == 0 ? 0 : 1;

  for (let i = start; i < num.length; i += 2) {
    let digit = parseInt(num[i]);
    num[i] = digit * 2 > 9 ? digit * 2 - 9 : digit * 2;
  }

  return num.reduce((sum, val) => sum + parseInt(val), 0) % 10 == 0;
};