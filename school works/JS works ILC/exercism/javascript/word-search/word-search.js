class WordSearch {
  constructor(grid = []) {
    this.grid = grid;
  }

  find(array = []) {
    const res = {};
    for (const word of array) {
      res[word] = this.findWord(word);
    }

    return res;
  }

  findWord(word) {
    const firstLetter = word[0];

    for (const start of this.findLetter(firstLetter)) {
      if (this.findRight(word, start)) {
        return {
          start,
          end: [start[0], start[1] + word.length - 1],
        };
      }
      if (this.findLeft(word, start)) {
        return {
          start,
          end: [start[0], start[1] - word.length + 1],
        };
      }
      if (this.findBottom(word, start)) {
        return {
          start,
          end: [start[0] + word.length - 1, start[1]],
        };
      }
      if (this.findTop(word, start)) {
        return {
          start,
          end: [start[0] - word.length + 1, start[1]],
        };
      }
      if (this.findBottomRight(word, start)) {
        return {
          start,
          end: [start[0] + word.length - 1, start[1] + word.length - 1],
        };
      }
      if (this.findBottomLeft(word, start)) {
        return {
          start,
          end: [start[0] + word.length - 1, start[1] - word.length + 1],
        };
      }
      if (this.findTopRight(word, start)) {
        return {
          start,
          end: [start[0] - word.length + 1, start[1] + word.length - 1],
        };
      }
      if (this.findTopLeft(word, start)) {
        return {
          start,
          end: [start[0] - word.length + 1, start[1] - word.length + 1],
        };
      }
    }

    return undefined;
  }

  findLetter(letter) {
    return this.grid.reduce((res, string, i) => {
      Array.prototype.forEach.call(string, (char, j) => {
        if (char === letter) {
          res.push([i + 1, j + 1]);
        }
      });
      return res;
    }, []);
  }

  findRight(word, start) {
    return (
      word ===
      this.grid[start[0] - 1].slice(start[1] - 1, start[1] - 1 + word.length)
    );
  }

  findLeft(word, start) {
    const end = start[1] - word.length + 1;
    if (end >= 1) {
      return (
        Array.from(this.grid[start[0] - 1].slice(end - 1, start[1]))
          .reverse()
          .join('') === word
      );
    } else {
      return false;
    }
  }

  findBottom(word, start) {
    let searchWord = '';
    const end = start[0] + word.length - 1;
    if (end <= this.grid.length) {
      for (let i = start[0] - 1; i < end; i++) {
        searchWord += this.grid[i][start[1] - 1];
      }
      return searchWord === word;
    } else {
      return false;
    }
  }

  findTop(word, start) {
    let searchWord = '';
    const end = start[0] - word.length + 1;

    if (end >= 1) {
      for (let i = start[0] - 1; i >= end - 1; i--) {
        searchWord += this.grid[i][start[1] - 1];
      }
      return searchWord === word;
    } else {
      return false;
    }
  }

  findBottomRight(word, start) {
    let searchWord = '';
    const end = [start[0] + word.length - 1, start[1] + word.length - 1];
    
    if (end[0] <= this.grid.length && end[1] <= this.grid[0].length) {
      for (let i = 0; i < word.length; i++) {
        searchWord += this.grid[start[0] - 1 + i][start[1] - 1 + i];
      }
      return searchWord === word;
    } else {
      return false;
    }
  }

  findBottomLeft(word, start) {
    let searchWord = '';
    const end = [start[0] + word.length - 1, start[1] - word.length + 1];
    
    if (end[0] <= this.grid.length && end[1] >= 1) {
      for (let i = 0; i < word.length; i++) {
        searchWord += this.grid[start[0] - 1 + i][start[1] - 1 - i];
      }
      return searchWord === word;
    } else {
      return false;
    }    
  }

  findTopRight(word, start) {
    let searchWord = '';
    const end = [start[0] - word.length + 1, start[1] + word.length - 1];
    
    if (end[0] >= 1 && end[1] <= this.grid[0].length) {
      for (let i = 0; i < word.length; i++) {
        searchWord += this.grid[start[0] - 1 - i][start[1] - 1 + i];
      }
      return searchWord === word;
    } else {
      return false;
    }    
  }

  findTopLeft(word, start) {
    let searchWord = '';
    const end = [start[0] - word.length + 1, start[1] - word.length + 1];
    
    if (end[0] >= 1 && end[1] >= 1) {
      for (let i = 0; i < word.length; i++) {
        searchWord += this.grid[start[0] - 1 - i][start[1] - 1 - i];
      }
      return searchWord === word;
    } else {
      return false;
    }    
  }
}

export default WordSearch;