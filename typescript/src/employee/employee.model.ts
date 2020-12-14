export class Employee {
    constructor(
        public FirstName: string,
        public LastName: string,
        public Id: number,
        public PhoneNumber: string,
        public SecuritySocialNumber: string) {
    }

    public GetAreaCode(): string {
        if (this.PhoneNumber !== undefined && this.PhoneNumber.length > 0 && this.PhoneNumber.startsWith("+") && this.PhoneNumber.indexOf("-") >= 0) {
            const parts = this.PhoneNumber.split('-');
            return parts[0];
        }
        else {
            throw new Error("No correct phone number.");
        }
    }

    public GetBirthYear() {
        if (this.SecuritySocialNumber !== undefined && this.SecuritySocialNumber.length === 13) {
            return this.SecuritySocialNumber.substr(1, 2);
        }
        else {
            throw new Error("No Social Security Number");
        }
    }
}