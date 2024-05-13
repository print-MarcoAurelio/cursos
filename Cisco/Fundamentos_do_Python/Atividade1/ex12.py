# Exercício 12 Faça um programa que calcule o IMC(Índice de Massa Corporal) e mostre o resultado na tela.

peso = float(input("Digite o seu peso em KG: "))
altura = float(input("Digite a sua altura em metros: "))
imc = peso / (altura ** 2)

print(f"O seu IMC é: {imc:.2f}")