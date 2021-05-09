export class RequestViewModel{
    id: number = 0;
    firstName: string = '';
    lastName: string = '';
    email: string = '';
}

export class RequestViewList{
    requests: RequestViewModel[] = [];
    recordsCount: number = 0;
}