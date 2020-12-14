import assert from 'assert';
import 'mocha';
import { Employee } from '../src/employee/employee.model';

describe('Employee', () => {
    const employeeWithEverything = new Employee("Jean", "DUPONT", 1, "+33-1-23-45-67-89", "1707533123456");
    it("Should return Area Code when valid", () => {
        assert.strictEqual('+33', employeeWithEverything.GetAreaCode());
    })
    it("Should return Birth Year when valid", () => {
        assert.strictEqual('70', employeeWithEverything.GetBirthYear());
    })

    const employeeWithIncorrectPhoneNumberAndIncorrectSocialSecurityNumber = new Employee("Marcel", "PAGNOL", 2, "12456789", "2843123456");
    it("Should throw error for Area Code when invalid", () => {
        assert.throws(() => employeeWithIncorrectPhoneNumberAndIncorrectSocialSecurityNumber.GetAreaCode());
    })
    it("Should throw error for Birth Year when invalid", () => {
        assert.throws(() => employeeWithIncorrectPhoneNumberAndIncorrectSocialSecurityNumber.GetBirthYear());
    })
})