import assert from 'assert';
import 'mocha';
import { Space } from '../src/long-method/space.model';

describe('Long Method', () => {
    it('Should not be a straight line (1 dot)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 0, z: 1 },
        ]);

        assert.strictEqual(false, space.IsStraightLine());
    });

    it('Should be a straight line (2 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 0, z: 1 },
            { x: 3, y: -1, z: 2 },
        ]);

        assert.strictEqual(true, space.IsStraightLine());
    });

    it('Should be a straight line (4 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 0, z: 1 },
            { x: 3, y: -1, z: 2 },
            { x: 7, y: -3, z: 4 },
            { x: 9, y: -4, z: 5 },
        ]);

        assert.strictEqual(true, space.IsStraightLine());
    });

    it('Should not be a straight line (4 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 0, z: 1 },
            { x: 3, y: 0, z: 2 },
            { x: 7, y: 0, z: 4 },
            { x: 9, y: 0, z: 7 },
        ]);

        assert.strictEqual(false, space.IsStraightLine());
    })

    it('Should not be an equilateral triangle (2 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 0, z: 1 },
            { x: 3, y: 0, z: 2 },
        ]);

        assert.strictEqual(false, space.IsEquilateralTriangle());
    })

    it('Should be an equilateral triangle (3 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 0, y: 0, z: 0 },
            { x: 3, y: Math.sqrt(Math.pow(6, 2) - Math.pow(3, 2)), z: 0 },
            { x: 6, y: 0, z: 0 },
        ]);

        assert.strictEqual(true, space.IsEquilateralTriangle());
    })

    it('Should not be an equilateral triangle (3 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 6, z: 0 },
            { x: 3, y: 7, z: 0 },
            { x: 9, y: 9, z: 0 },
        ]);

        assert.strictEqual(false, space.IsEquilateralTriangle());
    })

    it('Should not be a square triangle (2 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 0, z: 1 },
            { x: 3, y: 0, z: 2 },
        ]);

        assert.strictEqual(false, space.IsSquareTriangle());
    })

    it('Should be a square triangle (3 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 3, y: 0, z: 0 },
            { x: 0, y: 0, z: 0 },
            { x: 0, y: 3, z: 0 },
        ]);

        assert.strictEqual(true, space.IsSquareTriangle());
    })

    it('Should not be a square triangle (3 dots)', () => {
        const space = new Space();
        space.Add([
            { x: 1, y: 4, z: 0 },
            { x: 3, y: 7, z: 0 },
            { x: 9, y: 8, z: 0 },
        ]);

        assert.strictEqual(false, space.IsSquareTriangle());
    })
})