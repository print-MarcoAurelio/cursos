# Exercício 20 Desenvolver um programa de computador que calcule o reajuste de salário de um
# colaborador de uma empresa. Considere que o colaborador deve receber um reajuste de 15% caso
# seu salário seja menor que 500. Se o salário for maior ou igual a 500, mas menor ou igual a 1000, seu reajuste sera
# de 10%; caso seja ainda maior que 1000, o reajuste deve ser de 5%

salario_atual = float(input("Digite o salário atual do colaborador: "))
if salario_atual < 500:
    reajuste = salario_atual * 0.15
    novo_salario = salario_atual + reajuste
    percentual = 15
elif 500 <= salario_atual <= 1000:
    reajuste = salario_atual *0.10
    novo_salario = salario_atual + reajuste
    percentual = 10
else:
    reajuste = salario_atual * 0.05
    novo_salario = salario_atual + reajuste
    percentual = 5

print(f"Salário atual: R${salario_atual:.2f}")
print(f"Percentual de reajuste: {percentual}%")
print(f"Valor do reajuste: R${reajuste:.2f}")
print(f"Novo salário: R${novo_salario:.2f}")