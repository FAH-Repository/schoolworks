export class Triplet {
  constructor(a, b, c) {
    this.a = a
    this.b = b
    this.c = c
  }

  sum() {
    return this.a + this.b + this.c
  }

  product() {
    return this.a * this.b * this.c
  }

  isPythagorean() {
    return this.a ** 2 + this.b ** 2 === this.c ** 2
  }

  static where({ minFactor = 1, maxFactor = Number.MAX_SAFE_INTEGER, sum }) {
    let triplets = []

    for (let a = minFactor; a < maxFactor; a++) {
      for (let b = minFactor; b <= a; b++) {
        const c = Math.sqrt(a ** 2 + b ** 2)

        if (c % 1 === 0 // c is integer
            && (sum ? a + b + c === sum : true) // meets sum restriction
          ) 
        {
          triplets.push(new Triplet(a, b, c))
        }
      }
    }

    return triplets.sort((a,b) => a.product() > b.product())
  }
}