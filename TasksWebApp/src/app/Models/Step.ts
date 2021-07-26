export interface Step {

    StepId: number;
    Owner: string
    Name: string
    TaskId: number
    HasSubStep: boolean
    ParentId: number
}