import { SimpleStudentEvalute } from '../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';

function SimpleStudentDataEvalute(studentData: SimpleStudentEvalute) {
    return (
        <>
            <tr className="table-data-row">
                <th id="table-name">
                    <img src={studentData.studentAvatar} alt=""></img>
                    <span>{studentData.studentName}</span>
                </th>
                <th id="table-contact">
                    <span>{studentData.studentSdt}</span>
                </th>
                <th id="table-course">
                    <span>{studentData.studentCourse}</span>
                </th>
                <th id="table-turtol">
                    <span>{studentData.studentTurtor}</span>
                </th>
                <th id="table-active">
                    <span>{studentData.studentActive ? 'Active' : 'Offline'}</span>
                </th>
            </tr>
        </>
    );
}

export default SimpleStudentDataEvalute;
