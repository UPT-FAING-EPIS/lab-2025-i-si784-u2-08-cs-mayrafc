Feature: Cancelación de cuenta de ahorro

  Scenario: Cancelar cuenta con saldo cero
    Given la nueva cuenta numero 123 con saldo 0
    When el cliente cancela la cuenta
    Then la cuenta debe estar cancelada

  Scenario: Cancelar cuenta con saldo mayor a cero
    Given la nueva cuenta numero 456 con saldo 100
    When el cliente cancela la cuenta
    Then debe producirse un error con el mensaje: "No se puede cancelar una cuenta con saldo."
