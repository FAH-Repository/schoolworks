export class SpiralMatrix {
  static ofSize(size) {
    let matrix = '_'.repeat(size).split('').map(_ => '_'.repeat(size).split(''));
    let [x, y] = [0, 0];
    let [dx, dy] = [0, 1];
    for (let n = 1; n <= size * size; n++) {
      matrix[x][y] = n;
      x += dx;
      y += dy;
      if (!(x >= 0 && x < size && y >= 0 && y < size && matrix[x][y] === '_')) {
        x -= dx - dy;
        y -= dy + dx;
        [dx, dy] = [dy, -dx];
      }
    }
    return matrix;
  }
}