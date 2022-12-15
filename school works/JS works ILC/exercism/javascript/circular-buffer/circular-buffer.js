class CircularBuffer {
  constructor(size) {
    this.buffer = new Array(size);
    this.bufferSize = 0;
    this.start = undefined;
    this.next = 0;
  }

  write(item) {
    if (item === null || item === undefined) return;
    if (this.bufferSize >= this.buffer.length) throw new BufferFullError();
    else {
      this.buffer[this.next] = item;
      if (this.start === undefined) this.start = this.next;
      this.next = (this.next + 1) % this.buffer.length;
      this.bufferSize++;
    }
  }

  read() {
    if (this.bufferSize == 0) throw new BufferEmptyError();
    else {
      let temp = this.buffer[this.start];
      this.buffer[this.start] = undefined;
      this.start = (this.start+1)%this.buffer.length;
      this.bufferSize--;
      return temp;
    }
  }

  forceWrite(item) {
    if (item === null || item === undefined) return;
    if (this.bufferSize < this.buffer.length) {
      return this.write(item);
    } else {
      this.buffer[this.start] = item;
      this.start = (this.start + 1) % this.buffer.length;
      this.next = this.start;
    } 
  }

  clear() {
    this.buffer.map(item => item === undefined)
    this.bufferSize = 0;
    this.start = undefined;
    this.next = 0;
  }
}

export default CircularBuffer;

export class BufferFullError extends Error {
  constructor(message) {
    super(message);
  }
}

export class BufferEmptyError extends Error {
  constructor(message) {
    super(message);
  }
}