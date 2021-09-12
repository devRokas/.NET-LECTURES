const baseUrl =  "https://localhost:5001/todos";

async function getTodos() {
    const response = await fetch(baseUrl);
    const todos = response.json();

    return todos;
}

async function createTodo(todoItem) {
    const response = await fetch(baseUrl, {
        method: "POST",
        body: JSON.stringify(todoItem),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        }
    });

    return response.json();
}

async function updateTodo(updateTodo) {
    const response = await fetch(`${baseUrl}/${updateTodo.id}`, {
        method: "PUT",
        body: JSON.stringify({
            title: updateTodo.title,
            description: updateTodo.description,
        }),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        }
    });

    return response.json();
}


async function deleteTodo(id) {
    const response = await fetch(`${baseUrl}/${id}`, {
        method: "DELETE",
    });
}

async function updateTodoStatus(id) {
    const response = await fetch(`${baseUrl}/${id}/toggleStatus`, {
        method: "PATCH"
    });
}