# Exercício 9 Faça um programa que solicite um valor e converta km/h em m/s. Exiba o resultado na tela.

velocidade_km_h = float(input("Digite a velocidade em Km/h: "))
velocidade_m_s = velocidade_km_h * (5/18)

print(f"{velocidade_km_h} Km/h é igual a {velocidade_m_s:.2f} M/s")