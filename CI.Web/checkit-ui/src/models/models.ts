export interface CreateUserViewModel {
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  avatarUrl?: string;
}

export interface BoardViewModel {
  boardId: number;
  title: string;
  columns: ColumnViewModel[];
}

export interface ColumnViewModel {
  columnId: number;
  title: string;
  tickets: TicketViewModel[];
}

export interface TicketViewModel {
  ticketId: string;
  title: string;
  creationDate: string;
}

export interface CreateColumnViewModel {
  title: string;
  boardId: number;
}
