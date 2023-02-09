import Button from 'react-bootstrap/Button';
function StudentDetail() {
    return (
        <div className="StudentDetail" style={{ padding: '24px 32px' }}>
            <div className="detail-title">
                <h3>Student Detail</h3>
            </div>
            <div className="card" style={{ width: '400px', padding: '20px' }}>
                <div className="avatar" style={{ margin: '0 auto' }}>
                    <img
                        src="https://elstar.themenate.net/img/avatars/thumb-1.jpg"
                        alt=""
                        style={{ borderRadius: '50%' }}
                    />
                    <h4 style={{ marginTop: '20px', fontWeight: 'bold' }}>Nguyễn Quang Anh</h4>
                </div>
                <div className="info" style={{ marginTop: '32px', fontSize: '14px' }}>
                    <div>
                        <span>Email</span>
                        <p>quanganh@gmail.com</p>
                    </div>
                    <div>
                        <span>Phone</span>
                        <p>quanganh@gmail.com</p>
                    </div>
                    <div>
                        <span>Location</span>
                        <p>quanganh@gmail.com</p>
                    </div>
                    <div>
                        <span>Date of birth</span>
                        <p>quanganh@gmail.com</p>
                    </div>
                    <div>
                        <span>Title</span>
                        <p>quanganh@gmail.com</p>
                    </div>
                    <div style={{ display: 'flex', marginTop: '20px' }}>
                        <Button
                            variant="outline-secondary"
                            style={{ width: '50%', height: '36px', marginRight: '10px' }}
                        >
                            Delete
                        </Button>
                        <Button variant="primary" style={{ width: '50%' }}>
                            Edit
                        </Button>
                    </div>
                </div>
            </div>
        </div>
    );
}
export default StudentDetail;
