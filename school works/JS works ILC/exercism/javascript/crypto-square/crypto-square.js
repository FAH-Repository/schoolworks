export class Crypto {
  constructor(input) {
    this.input = input;
  }

  normalizePlaintext() {
    return this.input.replace(/[\W_]/g, '').toLowerCase();
  }

  size() {
    const length = this.normalizePlaintext().length;

    return Math.ceil(Math.sqrt(length));
  }

  plaintextSegments() {
    return this.normalizePlaintext().match(
      new RegExp(`\\w{1,${this.size()}}`, 'g'),
    );
  }

  ciphertext() {
    const plaintextSegments = this.plaintextSegments();
    const size = this.size();

    return Array.from({ length: size }, (_, k) =>
      plaintextSegments.reduce(
        (acc, cur) => acc + (k < cur.length ? cur[k] : ''),
        '',
      ),
    ).join('');
  }
}