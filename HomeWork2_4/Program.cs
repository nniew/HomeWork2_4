using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int n, k;
    String num = Console.ReadLine();
    String[] numsp = num.Split(' ');
    int.TryParse(numsp[0], out n);
    int.TryParse(numsp[1], out k);

    String population = Console.ReadLine();
    String[] populationsp = population.Split(' ');
    
    int[] p = new int[n];
    int[] result = new int[n];
    for (int i = 0; i < n; i++){
        int.TryParse(populationsp[i], out p[i]);
    }
    int total = 0;
    for(int i = k; i < n-k; i++){
      total = 0;
      for(int j = 1; j <= k; j++){
        total = total + p[i-j] + p[i] + p[i+j];
        }
      result[i] = total;
    }
    Console.WriteLine(result.Max());
  }
}