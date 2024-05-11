# Exercício 9 Escreva um programa que calcule a exponenciação de um valor de entrada. Imprima na tela o resultado.

base = float(input("Digite um valor da base: "))
expoente = float(input("Digite o valor do expoente: "))
resultado = base ** expoente

print(f"{base} elevado a {expoente} é igual a {resultado:.2f}")