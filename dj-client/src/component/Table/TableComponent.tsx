import Table from 'react-bootstrap/Table';
import './TableComponent.scss';
// function DataElement(studentData: object) {}
function TableComponent() {
    return (
        <div style={{ padding: '24px 32px' }}>
            <div className="table-title">
                <h3>Thống kê</h3>
            </div>
            <Table striped bordered hover responsive="sm">
                <thead>
                    <tr style={{ backgroundColor: '#ccc' }}>
                        <th>Họ tên</th>
                        <th>Khóa học</th>
                        <th>Ngày vào</th>
                        <th>Dự kiến kết thúc</th>
                        <th>Nghỉ không phép</th>
                        <th>Số ngày bảo lưu</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td style={{ cursor: 'pointer' }}>Bùi Chí Hiếu</td>
                        <th>Front-End</th>
                        <th>1/8/2022</th>
                        <th>1/10/2022</th>
                        <th>0</th>
                        <th>3</th>
                    </tr>
                </tbody>
            </Table>
        </div>
    );
}

export default TableComponent;
