export class Rectangles {
	static count(s){
		var c = 0;

		for(var y = 0; y < s.length; y++){
			var l = s[y];

			for(var x = 0; x < l.length; x++){
				if(l[x] != "+") continue;

				for(var nx = x + 1; nx < l.length; nx++){
					if(l[nx] == "-") continue;
					if(l[nx] != "+") break;

					for(var ny = y + 1; ny < s.length; ny++){
						var nl = s[ny].substring(x, nx + 1);

						if(!/^[+|].*[+|]$/.test(nl)) break;
						if(/^\+[+-]*\+$/.test(nl)) c++;
					}
				}
			}
		}

		return c;
	}
}