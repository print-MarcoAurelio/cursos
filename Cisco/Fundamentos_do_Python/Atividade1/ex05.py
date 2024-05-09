# Exercício 6 Faça um programa que calcule o aumento de um salário. Ele deve solicitar o valor do salário e a porcentagem do aumento. Exiba o valor do aumento e do novo salário.

salario_atual = float(input("Digite o valor do salário atual: "))
porcentagem_aumento = float(input("Digite a porcentagem do aumento (em %): "))
valor_aumento = (porcentagem_aumento / 100) * salario_atual
novo_salario = salario_atual + valor_aumento

print(f"Valor do aumento: R${valor_aumento:.2f}")
print(f"Novo salário: R${novo_salario}")