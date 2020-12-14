import { Dot } from "./dot.model";

export class Space {
    private dots: Dot[] = [];

    constructor() {
    }

    public Add = (dots: Dot[]): void => {
        this.dots.push(...dots);
    }

    public Clear = (): void => {
        this.dots = [];
    }

    public IsStraightLine = (): boolean => {
        if (this.dots.length < 2) {
            return false;
        }

        if (this.dots.length === 2) {
            return true;
        }

        const deltaX: number = this.dots[1].x - this.dots[0].x;
        const deltaY: number = this.dots[1].y - this.dots[0].y;
        const deltaZ: number = this.dots[1].z - this.dots[0].z;

        for (let index = 1; index < this.dots.length; index++) {
            const currentDot: Dot = this.dots[index];
            const previousDot: Dot = this.dots[index - 1];

            const currentDeltaX: number = currentDot.x - previousDot.x;
            const currentDeltaY: number = currentDot.y - previousDot.y;
            const currentDeltaZ: number = currentDot.z - previousDot.z;

            const coeffX = currentDeltaX / deltaX;
            const coeffY = currentDeltaY / deltaY;
            const coeffZ = currentDeltaZ / deltaZ;

            if (coeffX !== coeffY || coeffX !== coeffZ || coeffY !== coeffZ) {
                return false;
            }
        }

        return true;
    }

    public IsEquilateralTriangle = () => {
        if (this.dots.length !== 3) {
            return false;
        }

        const deltaX01: number = this.dots[1].x - this.dots[0].x;
        const deltaY01: number = this.dots[1].y - this.dots[0].y;
        const deltaZ01: number = this.dots[1].z - this.dots[0].z;

        const deltaX12: number = this.dots[2].x - this.dots[1].x;
        const deltaY12: number = this.dots[2].y - this.dots[1].y;
        const deltaZ12: number = this.dots[2].z - this.dots[1].z;

        const deltaX20: number = this.dots[0].x - this.dots[2].x;
        const deltaY20: number = this.dots[0].y - this.dots[2].y;
        const deltaZ20: number = this.dots[0].z - this.dots[2].z;

        // On compare ici les distances au carré pour éviter les problèmes d'arrondi avec Math.sqrt
        const squareDistance01 = (Math.pow(deltaX01, 2) + Math.pow(deltaY01, 2) + Math.pow(deltaZ01, 2));
        const squareDistance12 = (Math.pow(deltaX12, 2) + Math.pow(deltaY12, 2) + Math.pow(deltaZ12, 2));
        const squareDistance20 = (Math.pow(deltaX20, 2) + Math.pow(deltaY20, 2) + Math.pow(deltaZ20, 2));

        return squareDistance01 === squareDistance12 && squareDistance12 === squareDistance20;
    }

    public IsSquareTriangle = () => {
        if (this.dots.length !== 3) {
            return false;
        }

        const deltaX01: number = this.dots[1].x - this.dots[0].x;
        const deltaY01: number = this.dots[1].y - this.dots[0].y;
        const deltaZ01: number = this.dots[1].z - this.dots[0].z;

        const deltaX12: number = this.dots[2].x - this.dots[1].x;
        const deltaY12: number = this.dots[2].y - this.dots[1].y;
        const deltaZ12: number = this.dots[2].z - this.dots[1].z;

        const deltaX20: number = this.dots[0].x - this.dots[2].x;
        const deltaY20: number = this.dots[0].y - this.dots[2].y;
        const deltaZ20: number = this.dots[0].z - this.dots[2].z;

        const squareDistance01 = Math.pow(deltaX01, 2) + Math.pow(deltaY01, 2) + Math.pow(deltaZ01, 2);
        const squareDistance12 = Math.pow(deltaX12, 2) + Math.pow(deltaY12, 2) + Math.pow(deltaZ12, 2);
        const squareDistance20 = Math.pow(deltaX20, 2) + Math.pow(deltaY20, 2) + Math.pow(deltaZ20, 2);


        return (squareDistance01) === ((squareDistance12) + (squareDistance20))
            || (squareDistance12) === ((squareDistance20) + (squareDistance01))
            || (squareDistance20) === ((squareDistance12) + (squareDistance01));
    }
}