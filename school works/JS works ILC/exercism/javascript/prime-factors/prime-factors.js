export const primeFactors = (num) => {
  let i = 2;
  let factors = [];

  while(num > 1){
    if(num % i == 0){
      num /= i;
      factors.push(i);
    }else{
      i++;
    }
  }

  return factors;
};