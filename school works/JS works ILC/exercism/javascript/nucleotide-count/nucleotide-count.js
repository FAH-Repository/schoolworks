const DNA = {
  'A' : 0, 
  'C' : 0, 
  'G' : 0, 
  'T' : 0
}
export class NucleotideCounts {
  static parse(string) {
   
    string.split('').forEach(x => {
      if (x in DNA) {
        DNA[x]++; 
      } else {
        throw new Error('Invalid nucleotide in strand')
      }
                                  })
    
    return `${DNA['A']} ${DNA['C']} ${DNA['G']} ${DNA['T']}`
  }
}