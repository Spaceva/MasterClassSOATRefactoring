import assert from 'assert';
import 'mocha';
import { Employee } from '../src/primitive-obsession/employee.model';

describe('Primitive Obsession', () => {
    const employeeWithEverything = new Employee("Jean", "DUPONT", 1, "+33-1-23-45-67-89", "1707533123456");
    it("Should return Area Code of Jean DUPONT = '+33'", () => {
        assert.strictEqual('+33', employeeWithEverything.GetAreaCode());
    })
    it("Should return Birth Year of Jean DUPONT = 70", () => {
        assert.strictEqual('70', employeeWithEverything.GetBirthYear());
    })

    const employeeWithIncorrectPhoneNumber = new Employee("Marcel", "PAGNOL", 2, "12456789", "1847533123456");
    it("Should throw error for Area Code of Marcel PAGNOL", () => {
        assert.throws(() => employeeWithIncorrectPhoneNumber.GetAreaCode());
    })
    it("Should return Birth Year of Marcel PAGNOL = 84", () => {
        assert.strictEqual('84', employeeWithIncorrectPhoneNumber.GetBirthYear());
    })

    const employeeWithIncorrectSocialSecurityNumber = new Employee("Jeannine", "MARTIN", 3, "+102-6-23-45-67-89", "2843123456");
    it("Should return Area Code of Jeannine MARTIN = '+102'", () => {
        assert.strictEqual('+102', employeeWithIncorrectSocialSecurityNumber.GetAreaCode());
    })
    it("Should throw error for Birth Year of Jeannine MARTIN", () => {
        assert.throws(() => employeeWithIncorrectSocialSecurityNumber.GetBirthYear());
    })
})