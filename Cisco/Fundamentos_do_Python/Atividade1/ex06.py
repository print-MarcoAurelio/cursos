# Exercício 7 Escreva um programa que converta uma temperatura digitada em Graus Celsius em Graus Fahrenheit. A fórmula para essa conversão é:

temperatura_celsius = float(input("Digite a temperatura em graus celsius: "))
temperatura_fahrenheit = (temperatura_celsius * 9/5) + 32

print(f"{temperatura_celsius}°C é igual a {temperatura_fahrenheit:.2f}°F.")