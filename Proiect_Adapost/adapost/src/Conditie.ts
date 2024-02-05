import { Adapost } from "./Adapost";
import { Control } from "./Control";

export interface Conditie {
    id: string;
    denumire: string;
    gravitate: string;
    Adapost: Adapost;
    Controls: Control[];
    }