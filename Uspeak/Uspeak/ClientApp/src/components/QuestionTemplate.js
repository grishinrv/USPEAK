import React, { Component } from 'react';

export class QuestionTemplate extends Component {
    static displayName = QuestionTemplate.name;

    constructor(props) {
        super(props);
        this.state = { question: null, loading: true };
    }

    componentDidMount() {
        this.populateQuestionData();
    }

    static renderQuestionTable(question) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Текс вопроса</th>
                        <th>Пояснения</th>
                    </tr>
                </thead>
                <tbody>
                    <tr key={question.id}>
                        <td>{question.name}</td>
                        <td>{question.description}</td>
                    </tr>
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : QuestionTemplate.renderQuestionTable(this.state.question);

        return (
            <div>
                <h1 id="tabelLabel" >Шаблон вопроса</h1>
                <p>Создание и редактирование шаблона вопроса теста.</p>
                {contents}
            </div>
        );
    }

    async populateQuestionData() {
        const response = await fetch('QuestionSettings');
        const data = await response.json();
        this.setState({ question: data, loading: false });
    }
}
