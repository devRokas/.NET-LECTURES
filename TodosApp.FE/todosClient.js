async function getTodos() {
    const response = await fetch('https://localhost:5001/todos');

    return response.json();
}