export interface CreateUserViewModel {
    firstName: string,
    lastName: string,
    email: string,
    password: string,
    avatarUrl?: string
}

export interface BoardViewModel {
    title: string,
    columns: any[],
}