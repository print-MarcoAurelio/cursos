# Exercício 17 Faça um programa computacional que calcule a área de uma circunferência e exibir a medida da área calculada.

import math
raio = float(input("Digite o valor do raio de circuferencia: "))
area = math.pi * (raio ** 2)

print(f"A área da circuferencia é: {area:.2f}")