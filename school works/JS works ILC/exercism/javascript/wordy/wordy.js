class ArgumentError extends Error {
  constructor(message = '') {
    super(message);
    this.name = 'ArgumentError';
  }
}

class Wordy {
  constructor(question) {
    this.question = question;
  }

  answer() {
    const digitMatchGlobal = /-?\d+/g;
    const digitMatch = /-?\d+/;
    const digitsArray = this.question.match(digitMatchGlobal);
    const splitString = this.question.split(digitMatch);
    let answer = !!digitsArray ? parseInt(digitsArray[0]) : null;
    if(splitString[0].toLowerCase().includes('what is') && digitsArray.length >= 2) {
      for(let i = 0; i < digitsArray.length - 1; i++) {
        if (splitString[i+1].toLowerCase().includes('plus')) {
            answer = answer + parseInt(digitsArray[i+1]);
        } else if (splitString[i+1].toLowerCase().includes('minus')) {
            answer = answer - parseInt(digitsArray[i+1]);
        } else if (splitString[i+1].toLowerCase().includes('multiplied by')) {
          answer = answer * parseInt(digitsArray[i+1]);
        } else if (splitString[i+1].toLowerCase().includes('divided by')) {
          answer = answer / parseInt(digitsArray[i+1]);
        } else {
          throw new ArgumentError('No work');
        }
      }
      return answer;
    }
    
    throw new ArgumentError('No work');
  }
}

export { Wordy as WordProblem, ArgumentError };