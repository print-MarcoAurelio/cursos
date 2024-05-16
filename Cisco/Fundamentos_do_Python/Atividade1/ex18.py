# Exercício 18 Desenvolva um software que calcule o volume de uma lata de refrigerante imprimir o resultado.

import math
raio = float(input("Digite o raio da lata de refrigerente (em centínetros): "))
altura = float(input("Digite a altura da lata de refrigerante (em centímetros)"))
volume = math.pi * (raio ** 2) * altura

print(f"O volume da lata de refrigerante é: {volume:.2f} cm³")